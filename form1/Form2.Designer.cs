namespace form1
{
    partial class Form2
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

        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
          
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(310, 152);
            label2.Name = "label2";
            label2.Size = new Size(109, 38);
            label2.TabIndex = 1;
            label2.Text = "Sign In";
           
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(228, 212);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 2;
            label3.Text = "Username:";
        
            textBox1.Location = new Point(228, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 27);
            textBox1.TabIndex = 3;
    
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(230, 297);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            label4.Click += label4_Click;
 
            textBox2.Location = new Point(228, 334);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 27);
            textBox2.TabIndex = 5;

            label5.AutoSize = true;
            label5.Location = new Point(278, 430);
            label5.Name = "label5";
            label5.Size = new Size(163, 20);
            label5.TabIndex = 6;
            label5.Text = "Don't have an account?";
            label5.Click += label5_Click;
        
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(278, 453);
            button1.Name = "button1";
            button1.Size = new Size(145, 29);
            button1.TabIndex = 7;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
          
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 67);
            label1.Name = "label1";
            label1.Size = new Size(247, 38);
            label1.TabIndex = 8;
            label1.Text = "Inventory System";
        
            button2.BackColor = Color.Lime;
            button2.Location = new Point(310, 380);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Log In";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
        
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(749, 533);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Inventory Management System/david";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}