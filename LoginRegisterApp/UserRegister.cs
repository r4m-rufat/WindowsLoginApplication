using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegisterApp
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }
        // variables
        String path = @"details.txt";
        String error_message = "";
        private void UserRegister_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (checkRegisterFields())
            {
                StreamWriter streamWriter = new StreamWriter(path, append: true);
                streamWriter.Write("Username: " + tb_username.Text.Trim() + " - Password: " + tb_password.Text.Trim() +
                    "\nFullname: " + tb_fullname.Text.Trim() +
                    "\nEmail: " + tb_email.Text.Trim() + "\n");

                streamWriter.Close();

                lb_error_message.Visible = false;
                lb_success_message.Visible = true;
            }
            else
            {
                lb_error_message.Text = error_message;
                lb_error_message.Visible = true;
            }
        }

        private void lb_pass_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin user = new UserLogin();
            user.Show();
        }

        /**
         * 6th  condition with function
         * this function checks all fields and return a boolean
         */
        private Boolean checkRegisterFields()
        {
            bool username = false;
            bool password = false;
            bool email = false;
            bool fullname = false;

            error_message = "";

            if (!String.IsNullOrEmpty(tb_username.Text.Trim()))
            {
                username = true;
            }

            if (!String.IsNullOrEmpty(tb_fullname.Text.Trim()))
            {
                if (tb_fullname.Text.Length >= 10)
                {
                    fullname = true;
                }
                else
                {
                    error_message += "Fullname can't be less than 10!\n";
                }

            }

            if (!String.IsNullOrEmpty(tb_email.Text.Trim()))
            {
                email = true;
            }

            if (tb_password.Text.Trim().Length >= 6)
            {
                if (tb_password.Text.Trim().Equals(tb_confirm_password.Text.Trim()))
                {
                    password = true;
                }
                else
                {
                    error_message += "Passwords doesn't match!\n";
                }
            }
            else
            {
                error_message += "Password must be at least 6 characters length";
            }

            // if any field is empty or null then error message is changed
            if (String.IsNullOrEmpty(tb_username.Text.Trim()) ||
                String.IsNullOrEmpty(tb_email.Text.Trim()) ||
                String.IsNullOrEmpty(tb_password.Text.Trim()) ||
                String.IsNullOrEmpty(tb_confirm_password.Text.Trim()) ||
                String.IsNullOrEmpty(tb_fullname.Text.Trim()))
            {
                error_message = "Some fields are empty!";
            }

            return username && password && email && fullname; 
        }

    }
}
