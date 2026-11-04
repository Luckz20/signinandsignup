using System;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace form1
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void Form2_Load(object sender, EventArgs e) { }

        private void label_CreateAccount_Click(object sender, EventArgs e)
        {
            Form3 signup = new Form3();
            signup.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 signup = new Form3();
            signup.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            try
            {
                using (OleDbConnection con =
                    new OleDbConnection(GetConnectionString()))
                {
                    con.Open();

                    string query =
                        "SELECT COUNT(*) FROM [Users] " +
                        "WHERE [Username] = ? AND [UserPassword] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add(
                            "@Username", OleDbType.VarWChar
                        ).Value = username;

                        cmd.Parameters.Add(
                            "@UserPassword", OleDbType.VarWChar, 64
                        ).Value = HashPassword(password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!");
                            Form1 dashboard = new Form1();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Wrong username or password, or you are not registered yet."
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message);
            }
        }
    }
}