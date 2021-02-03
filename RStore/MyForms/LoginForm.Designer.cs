namespace RStore
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_LoginPassword = new System.Windows.Forms.TextBox();
            this.txb_LoginEmail = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_RegisterInLoginForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(81, 46);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(81, 104);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password";
            // 
            // txb_LoginPassword
            // 
            this.txb_LoginPassword.Location = new System.Drawing.Point(99, 120);
            this.txb_LoginPassword.Name = "txb_LoginPassword";
            this.txb_LoginPassword.Size = new System.Drawing.Size(100, 20);
            this.txb_LoginPassword.TabIndex = 2;
            // 
            // txb_LoginEmail
            // 
            this.txb_LoginEmail.Location = new System.Drawing.Point(99, 62);
            this.txb_LoginEmail.Name = "txb_LoginEmail";
            this.txb_LoginEmail.Size = new System.Drawing.Size(100, 20);
            this.txb_LoginEmail.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(59, 164);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(86, 39);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_RegisterInLoginForm
            // 
            this.btn_RegisterInLoginForm.Location = new System.Drawing.Point(151, 164);
            this.btn_RegisterInLoginForm.Name = "btn_RegisterInLoginForm";
            this.btn_RegisterInLoginForm.Size = new System.Drawing.Size(86, 39);
            this.btn_RegisterInLoginForm.TabIndex = 5;
            this.btn_RegisterInLoginForm.Text = "Register";
            this.btn_RegisterInLoginForm.UseVisualStyleBackColor = true;
            this.btn_RegisterInLoginForm.Click += new System.EventHandler(this.btn_RegisterInLoginForm_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 304);
            this.Controls.Add(this.btn_RegisterInLoginForm);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txb_LoginEmail);
            this.Controls.Add(this.txb_LoginPassword);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Email);
            this.Name = "LoginForm";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_LoginPassword;
        private System.Windows.Forms.TextBox txb_LoginEmail;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_RegisterInLoginForm;
    }
}

