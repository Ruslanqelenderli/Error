using RStore.DAL;
using RStore.MyForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_RegisterInLoginForm_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
        MyDatabase my = new MyDatabase();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            
            
            
            string email = txb_LoginEmail.Text;
            string password = txb_LoginPassword.Text;

            bool result1 = my.UserChecking(email, password);
            if (result1)
            {
                if (my.AdminChecking())
                {
                    SelectForm selectForm = new SelectForm();
                    selectForm.ShowDialog();
                }
                else
                {
                    AdminSelectForm adminSelectForm = new AdminSelectForm();
                    adminSelectForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wrong!");
            }
        }

       
    }
}
