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
        Form8 firescreen = new Form8();
        public Form3()
        {
            InitializeComponent();
            var src = (Bitmap)Bitmap.FromFile("로고.png");

            // 소스이미지 크기와 동일한 타겟이미지 생성
            Bitmap tgt = new Bitmap(src.Width, src.Height);

            // 타겟이미지의 Graphics 객체 얻기        
            using (Graphics g = Graphics.FromImage(tgt))
            {
                // 배경색을 설정
                var rect = new Rectangle(0, 0, tgt.Width, tgt.Height);
                using (Brush br = new SolidBrush(SystemColors.Control))
                {
                    g.FillRectangle(br, 0, 0, tgt.Width, tgt.Height);
                }
                // 소스이미지를 원모양으로 잘라 타겟이미지에 출력
                g.DrawImage(src, 0, 0);
            }
            // PictureBox에 이미지 출력
            pictureBox2.Image = tgt;

            var src1 = (Bitmap)Bitmap.FromFile("뒤로가기1.png");

            // 소스이미지 크기와 동일한 타겟이미지 생성
            Bitmap tgt1 = new Bitmap(src1.Width, src1.Height);

            // 타겟이미지의 Graphics 객체 얻기        
            using (Graphics g = Graphics.FromImage(tgt1))
            {
                // 배경색을 설정
                var rect = new Rectangle(0, 0, tgt1.Width, tgt1.Height);
                using (Brush br = new SolidBrush(SystemColors.Control))
                {
                    g.FillRectangle(br, 0, 0, tgt1.Width, tgt1.Height);
                }
                // 소스이미지를 원모양으로 잘라 타겟이미지에 출력
                g.DrawImage(src1, 0, 0);
            }
            // PictureBox에 이미지 출력
            pictureBox6.Image = tgt1;
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
            firescreen.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            skyscreen.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Close();
        }
    }
}
