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
    }
}
