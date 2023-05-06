using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class choose_role : UserControl
    {
        
        
        Admin_login_control admin= new Admin_login_control();
        public choose_role()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel1.Controls.Add(admin);
            admin.Dock= DockStyle.Fill;             



        }
    }
}