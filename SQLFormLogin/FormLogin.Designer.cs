﻿namespace SQLFormLogin
{
    partial class form_Login
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
            button_Clear = new Button();
            button_Login = new Button();
            button_Exit = new Button();
            label_Username = new Label();
            label_password = new Label();
            textBox_Username = new TextBox();
            textBox_password = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(278, 250);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(94, 29);
            button_Clear.TabIndex = 0;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // button_Login
            // 
            button_Login.Location = new Point(389, 250);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(94, 29);
            button_Login.TabIndex = 1;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(100, 320);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(94, 29);
            button_Exit.TabIndex = 2;
            button_Exit.Text = "Exit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Location = new Point(124, 123);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(75, 20);
            label_Username.TabIndex = 3;
            label_Username.Text = "Username";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(124, 182);
            label_password.Name = "label_password";
            label_password.Size = new Size(72, 20);
            label_password.TabIndex = 4;
            label_password.Text = "password";
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(243, 125);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(266, 27);
            textBox_Username.TabIndex = 5;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(243, 179);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(266, 27);
            textBox_password.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(211, 43);
            label1.Name = "label1";
            label1.Size = new Size(196, 57);
            label1.TabIndex = 7;
            label1.Text = "Welcome";
            // 
            // form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 383);
            Controls.Add(label1);
            Controls.Add(textBox_password);
            Controls.Add(textBox_Username);
            Controls.Add(label_password);
            Controls.Add(label_Username);
            Controls.Add(button_Exit);
            Controls.Add(button_Login);
            Controls.Add(button_Clear);
            Name = "form_Login";
            Text = "Login";
            Load += form_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Clear;
        private Button button_Login;
        private Button button_Exit;
        private Label label_Username;
        private Label label_password;
        private TextBox textBox_Username;
        private TextBox textBox_password;
        private Label label1;
    }
}
