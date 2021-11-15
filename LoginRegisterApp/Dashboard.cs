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
    public partial class Dashboard : Form
    {
        string fullame = "";
        public Dashboard(string newname)
        {
            this.fullame = newname;
            InitializeComponent();
        }

        String path = @"data.txt";


        private void Dashboard_Load(object sender, EventArgs e)
        {
            lb_fullname.Text = "Hello, " + fullame;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter(path, append: true);
            sr.WriteLine(tb_write_form.Text.Trim());
            sr.Close();
            tb_write_form.Text = "";

        }



    }
}
