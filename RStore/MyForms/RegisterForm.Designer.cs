namespace RStore.MyForms
{
    partial class RegisterForm
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
            this.btn_RegisterInRegisterForm = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_PasswordInRegisterForm = new System.Windows.Forms.Label();
            this.lbl_EmailInRegisterForm = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_Surname = new System.Windows.Forms.TextBox();
            this.txb_EmailInRegisterForm = new System.Windows.Forms.TextBox();
            this.txb_PasswordInRegisterForm = new System.Windows.Forms.TextBox();
            this.lbl_PasswordAgain = new System.Windows.Forms.Label();
            this.txb_PasswordAgain = new System.Windows.Forms.TextBox();
            this.txb_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_RegisterInRegisterForm
            // 
            this.btn_RegisterInRegisterForm.Location = new System.Drawing.Point(163, 292);
            this.btn_RegisterInRegisterForm.Name = "btn_RegisterInRegisterForm";
            this.btn_RegisterInRegisterForm.Size = new System.Drawing.Size(75, 41);
            this.btn_RegisterInRegisterForm.TabIndex = 0;
            this.btn_RegisterInRegisterForm.Text = "Register";
            this.btn_RegisterInRegisterForm.UseVisualStyleBackColor = true;
            this.btn_RegisterInRegisterForm.Click += new System.EventHandler(this.btn_RegisterInRegisterForm_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(41, 30);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(41, 69);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(49, 13);
            this.lbl_Surname.TabIndex = 2;
            this.lbl_Surname.Text = "Surname";
            // 
            // lbl_PasswordInRegisterForm
            // 
            this.lbl_PasswordInRegisterForm.AutoSize = true;
            this.lbl_PasswordInRegisterForm.Location = new System.Drawing.Point(41, 186);
            this.lbl_PasswordInRegisterForm.Name = "lbl_PasswordInRegisterForm";
            this.lbl_PasswordInRegisterForm.Size = new System.Drawing.Size(53, 13);
            this.lbl_PasswordInRegisterForm.TabIndex = 3;
            this.lbl_PasswordInRegisterForm.Text = "Password";
            // 
            // lbl_EmailInRegisterForm
            // 
            this.lbl_EmailInRegisterForm.AutoSize = true;
            this.lbl_EmailInRegisterForm.Location = new System.Drawing.Point(41, 147);
            this.lbl_EmailInRegisterForm.Name = "lbl_EmailInRegisterForm";
            this.lbl_EmailInRegisterForm.Size = new System.Drawing.Size(32, 13);
            this.lbl_EmailInRegisterForm.TabIndex = 4;
            this.lbl_EmailInRegisterForm.Text = "Email";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(53, 46);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(100, 20);
            this.txb_Name.TabIndex = 5;
            // 
            // txb_Surname
            // 
            this.txb_Surname.Location = new System.Drawing.Point(53, 85);
            this.txb_Surname.Name = "txb_Surname";
            this.txb_Surname.Size = new System.Drawing.Size(100, 20);
            this.txb_Surname.TabIndex = 6;
            // 
            // txb_EmailInRegisterForm
            // 
            this.txb_EmailInRegisterForm.Location = new System.Drawing.Point(53, 163);
            this.txb_EmailInRegisterForm.Name = "txb_EmailInRegisterForm";
            this.txb_EmailInRegisterForm.Size = new System.Drawing.Size(100, 20);
            this.txb_EmailInRegisterForm.TabIndex = 7;
            // 
            // txb_PasswordInRegisterForm
            // 
            this.txb_PasswordInRegisterForm.Location = new System.Drawing.Point(53, 202);
            this.txb_PasswordInRegisterForm.Name = "txb_PasswordInRegisterForm";
            this.txb_PasswordInRegisterForm.Size = new System.Drawing.Size(100, 20);
            this.txb_PasswordInRegisterForm.TabIndex = 8;
            // 
            // lbl_PasswordAgain
            // 
            this.lbl_PasswordAgain.AutoSize = true;
            this.lbl_PasswordAgain.Location = new System.Drawing.Point(41, 225);
            this.lbl_PasswordAgain.Name = "lbl_PasswordAgain";
            this.lbl_PasswordAgain.Size = new System.Drawing.Size(83, 13);
            this.lbl_PasswordAgain.TabIndex = 9;
            this.lbl_PasswordAgain.Text = "Password Again";
            // 
            // txb_PasswordAgain
            // 
            this.txb_PasswordAgain.Location = new System.Drawing.Point(53, 241);
            this.txb_PasswordAgain.Name = "txb_PasswordAgain";
            this.txb_PasswordAgain.Size = new System.Drawing.Size(100, 20);
            this.txb_PasswordAgain.TabIndex = 10;
            // 
            // txb_PhoneNumber
            // 
            this.txb_PhoneNumber.Location = new System.Drawing.Point(53, 124);
            this.txb_PhoneNumber.Name = "txb_PhoneNumber";
            this.txb_PhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txb_PhoneNumber.TabIndex = 11;
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(41, 108);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lbl_PhoneNumber.TabIndex = 12;
            this.lbl_PhoneNumber.Text = "Phone Number";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 345);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.txb_PhoneNumber);
            this.Controls.Add(this.txb_PasswordAgain);
            this.Controls.Add(this.lbl_PasswordAgain);
            this.Controls.Add(this.txb_PasswordInRegisterForm);
            this.Controls.Add(this.txb_EmailInRegisterForm);
            this.Controls.Add(this.txb_Surname);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lbl_EmailInRegisterForm);
            this.Controls.Add(this.lbl_PasswordInRegisterForm);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_RegisterInRegisterForm);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_RegisterInRegisterForm;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_PasswordInRegisterForm;
        private System.Windows.Forms.Label lbl_EmailInRegisterForm;
        public System.Windows.Forms.TextBox txb_Name;
        public System.Windows.Forms.TextBox txb_Surname;
        public System.Windows.Forms.TextBox txb_EmailInRegisterForm;
        public System.Windows.Forms.TextBox txb_PasswordInRegisterForm;
        private System.Windows.Forms.Label lbl_PasswordAgain;
        public System.Windows.Forms.TextBox txb_PasswordAgain;
        public System.Windows.Forms.TextBox txb_PhoneNumber;
        private System.Windows.Forms.Label lbl_PhoneNumber;
    }
}