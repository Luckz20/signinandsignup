
using System;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace form1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private string GetConnectionString()
        {
            string dbPath = Path.Combine(
                Application.StartupPath,
                "InventoryDB.accdb"
            );

            if (!File.Exists(dbPath))
            {
                throw new FileNotFoundException(
                    "InventoryDB.accdb not found: " + dbPath
                );
            }

            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                   dbPath + ";Persist Security Info=False;";
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(
                    Encoding.UTF8.GetBytes(password)
                );

                return BitConverter.ToString(bytes)
                    .Replace("-", "").ToLower();
            }
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void Form3_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (fullname == "" || username == "" ||
                email == "" || password == "" ||
                confirmPassword == "")
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show(
                    "Password must be at least 8 characters."
                );
                return;
            }

            try
            {
                using (OleDbConnection con =
                    new OleDbConnection(GetConnectionString()))
                {
                    con.Open();

                    string checkQuery =
                        "SELECT COUNT(*) FROM [Users] " +
                        "WHERE [Username] = ? OR [Email] = ?";

                    using (OleDbCommand check =
                        new OleDbCommand(checkQuery, con))
                    {
                        check.Parameters.Add(
                            "@Username", OleDbType.VarWChar
                        ).Value = username;

                        check.Parameters.Add(
                            "@Email", OleDbType.VarWChar
                        ).Value = email;

                        int exists = Convert.ToInt32(
                            check.ExecuteScalar()
                        );

                        if (exists > 0)
                        {
                            MessageBox.Show(
                                "Username or Email already exists."
                            );
                            return;
                        }
                    }

                    string insertQuery =
                        "INSERT INTO [Users] " +
                        "([FullName], [Username], [Email], [UserPassword], [DateCreated]) " +
                        "VALUES (?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd =
                        new OleDbCommand(insertQuery, con))
                    {
                        cmd.Parameters.Add(
                            "@FullName", OleDbType.VarWChar
                        ).Value = fullname;

                        cmd.Parameters.Add(
                            "@Username", OleDbType.VarWChar
                        ).Value = username;

                        cmd.Parameters.Add(
                            "@Email", OleDbType.VarWChar
                        ).Value = email;

                        cmd.Parameters.Add(
                            "@UserPassword", OleDbType.VarWChar, 64
                        ).Value = HashPassword(password);

                        cmd.Parameters.Add(
                            "@DateCreated", OleDbType.Date
                        ).Value = DateTime.Now;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registration Successful!");

                Form2 login = new Form2();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Registration Error: " + ex.Message
                );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }
    }
}
