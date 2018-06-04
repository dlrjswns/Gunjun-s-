using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form3 : Form
    {
        Form2 HuntScreen = new Form2();
        Form4 waterscreen = new Form4();
        Form5 glassscreen = new Form5();
        Form6 cloudscreen = new Form6();
        Form7 skyscreen = new Form7();
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HuntScreen.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            waterscreen.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            glassscreen.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cloudscreen.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            skyscreen.ShowDialog();
        }
       

    }
}
