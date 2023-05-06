using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace DB_Project
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void add_student_button_Click(object sender, EventArgs e)
        {
          

            Add_student student= new Add_student(); 

            panel1.Controls.Clear();
            panel1.Controls.Add(student);   
            student.Dock= DockStyle.Fill;       


        }

        private void button1_Click(object sender, EventArgs e)
        {









        }

        private void add_teacher_button_Click(object sender, EventArgs e)
        {

            UserControl1 u1= new UserControl1();

            panel1.Controls.Clear(); 
           panel1.Controls.Add(u1);    


            u1.Dock= DockStyle.Fill;
          





        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void student_view_button_Click(object sender, EventArgs e)
        {

            Students stude= new Students();

            panel1.Controls.Clear();   
            panel1.Controls.Add(stude);
            stude.Dock= DockStyle.Fill;



        }

        private void teacher_view_button_Click(object sender, EventArgs e)
        {


            Teachers teachers= new Teachers();
            panel1.Controls.Clear();

            panel1.Controls.Add(teachers);

            teachers.Dock= DockStyle.Fill;



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
