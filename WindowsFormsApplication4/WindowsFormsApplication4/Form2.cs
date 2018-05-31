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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Bitmap bit;//gif 출력 코딩퍼옴 https://m.blog.naver.com/PostView.nhn?blogId=goldrushing&logNo=130184365511&proxyReferer=https%3A%2F%2Fwww.google.co.kr%2F
        Bitmap bit1;
        protected override void OnLoad(EventArgs e)
        {
            bit = new Bitmap("chu13.gif");
            ImageAnimator.Animate(bit, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit1 = new Bitmap("sleep.gif");
            ImageAnimator.Animate(bit1, new EventHandler(this.OnFrameChanged1));
            base.OnLoad(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames();
            Graphics g = pictureBox2.CreateGraphics();
            g.DrawImage(this.bit, new Point(0, 0));
            base.OnPaint(e);

            ImageAnimator.UpdateFrames();
            Graphics h = pictureBox1.CreateGraphics();
            h.DrawImage(this.bit1, new Point(0, 0));
            base.OnPaint(e);
        }
        private void OnFrameChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
       
  
        //protected override void OnLoad(EventArgs e)
        //{
        //    bit1 = new Bitmap("sleep.gif");
        //    ImageAnimator.Animate(bit1, new EventHandler(this.OnFrameChanged1));
        //    base.OnLoad(e);
        //}
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    ImageAnimator.UpdateFrames();
        //    Graphics g = pictureBox1.CreateGraphics();
        //    g.DrawImage(this.bit1, new Point(0, 0));
        //    base.OnPaint(e);
        //}
        private void OnFrameChanged1(object sender, EventArgs e)
        {
            this.Invalidate();
        }


        private void HuntScreen1_Click(object sender, EventArgs e)
        {

        }

        private void chu3D_Click(object sender, EventArgs e)
        {
            
    }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void bodyhit()
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
