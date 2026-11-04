namespace form1
{
    partial class Form3
    {
  
        private System.ComponentModel.IContainer components = null;

     
        /// <param name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            this.txtFullName = new TextBox();
            this.txtUsername = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            label9 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 34);
            label2.Name = "label2";
            label2.Size = new Size(247, 38);
            label2.TabIndex = 1;
            label2.Text = "Inventory System";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(297, 93);
            label3.Name = "label3";
            label3.Size = new Size(120, 38);
            label3.TabIndex = 2;
            label3.Text = "Sign Up";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new Point(240, 179);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new Size(247, 27);
            this.txtFullName.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new Point(240, 238);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(247, 27);
            this.txtUsername.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(240, 299);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(247, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new Point(240, 360);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(247, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(240, 420);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(247, 27);
            txtConfirmPassword.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(240, 149);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 6;
            label4.Text = "Full Name:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(243, 208);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 7;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(240, 268);
            label6.Name = "label6";
            label6.Size = new Size(150, 28);
            label6.TabIndex = 8;
            label6.Text = "Email Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(245, 329);
            label7.Name = "label7";
            label7.Size = new Size(108, 28);
            label7.TabIndex = 9;
            label7.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(240, 389);
            label8.Name = "label8";
            label8.Size = new Size(191, 28);
            label8.TabIndex = 10;
            label8.Text = "Confirm Password:";
            label8.Click += label8_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Location = new Point(297, 459);
            button1.Name = "button1";
            button1.Size = new Size(135, 45);
            button1.TabIndex = 11;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(276, 507);
            label9.Name = "label9";
            label9.Size = new Size(181, 20);
            label9.TabIndex = 12;
            label9.Text = "Already Have an account?";
            label9.Click += label9_Click;
            // 
            // button2
            // 
            button2.Location = new Point(292, 530);
            button2.Name = "button2";
            button2.Size = new Size(145, 29);
            button2.TabIndex = 13;
            button2.Text = "Back to Sign In";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(749, 584);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtConfirmPassword);
            Controls.Add(this.txtPassword);
            Controls.Add(this.txtEmail);
            Controls.Add(this.txtUsername);
            Controls.Add(this.txtFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Inventory Management System/david";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Label label9;
        private Button button2;
    }
}