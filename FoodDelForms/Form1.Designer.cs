namespace FoodDelForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Login = new Button();
            label1 = new Label();
            label2 = new Label();
            EmailId = new TextBox();
            Password = new TextBox();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Location = new Point(680, 45);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 58);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "Email Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 54);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // EmailId
            // 
            EmailId.Location = new Point(136, 51);
            EmailId.Name = "EmailId";
            EmailId.Size = new Size(125, 27);
            EmailId.TabIndex = 3;
            // 
            // Password
            // 
            Password.Location = new Point(433, 47);
            Password.Name = "Password";
            Password.Size = new Size(125, 27);
            Password.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 450);
            Controls.Add(Password);
            Controls.Add(EmailId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Login);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private Label label1;
        private Label label2;
        private TextBox EmailId;
        private TextBox Password;
    }
}
