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
    public partial class UserLogin : Form
    {

        public string fullname = "";
        String path = @"details.txt";
        bool existUser = false;
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                FileStream fileStream = File.Create(path);
                fileStream.Close();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {

                StreamReader sr = new StreamReader(path);

                string everyLine = "";
                while ((everyLine = sr.ReadLine()) != null)
                {
                    if (everyLine.StartsWith("Username: "))
                    {

                        if (everyLine.Split('-')[0].Split(':')[1].Trim().Equals(tb_username.Text.Trim()) &&
                        everyLine.Split('-')[1].Split(':')[1].Trim().Equals(tb_password.Text.Trim()))
                        {

                            string fullnameLine = sr.ReadLine(); // because next line belongs fullname
                            fullname = fullnameLine.Split(':')[1].Trim();
                            existUser = true;
                            break;


                        }


                    }
                }

                sr.Close();

            }
            if (existUser)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard(fullname);
                dashboard.Show();
            }
            else
            {
                lb_error_message.Visible = true;
            }
        }

        private void lb_create_new_account_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UserRegister userRegister = new UserRegister();
            userRegister.Show();
        }

        
    }
}
