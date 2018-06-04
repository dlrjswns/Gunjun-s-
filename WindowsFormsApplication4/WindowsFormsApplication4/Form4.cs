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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Bitmap bit;//gif 출력 코딩퍼옴 https://m.blog.naver.com/PostView.nhn?blogId=goldrushing&logNo=130184365511&proxyReferer=https%3A%2F%2Fwww.google.co.kr%2F
        Bitmap bit1;
        Bitmap bit2;
        Bitmap bit3;
        protected override void OnLoad(EventArgs e)
        {
            bit = new Bitmap("거북왕1.gif");
            ImageAnimator.Animate(bit, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit1 = new Bitmap("chu13.gif");
            ImageAnimator.Animate(bit1, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit2 = new Bitmap("거북왕.gif");
            ImageAnimator.Animate(bit1, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit3 = new Bitmap("chu1.gif");
            ImageAnimator.Animate(bit3, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames();
            Graphics g = pictureBox2.CreateGraphics();
            g.DrawImage(this.bit, new Point(-70, 0));
            base.OnPaint(e);

            ImageAnimator.UpdateFrames();
            Graphics h = pictureBox3.CreateGraphics();
            h.DrawImage(this.bit1, new Point(0, 0));
            base.OnPaint(e);

            ImageAnimator.UpdateFrames();
            Graphics t = pictureBox4.CreateGraphics();
            t.DrawImage(this.bit2, new Point(0, 0));
            base.OnPaint(e);

            ImageAnimator.UpdateFrames();
            Graphics y = pictureBox1.CreateGraphics();
            y.DrawImage(this.bit3, new Point(0, 0));
            base.OnPaint(e);
        }
        private void OnFrameChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
