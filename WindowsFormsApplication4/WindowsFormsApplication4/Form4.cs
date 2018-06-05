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
        int number = 0;
        public Form4()
        {
            InitializeComponent();
            progressBar1.Value = 100;
            progressBar2.Value = 100;
        }
        public void Init()//progressbar 맥시멈과 미니멈을 정해주어 넘치지 않도록
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            
            progressBar1.Value = 0;

        }
        Bitmap bit;//gif 출력 코딩퍼옴 https://m.blog.naver.com/PostView.nhn?blogId=goldrushing&logNo=130184365511&proxyReferer=https%3A%2F%2Fwww.google.co.kr%2F
        Bitmap bit1;
        Bitmap bit2;
        Bitmap bit3;
        Bitmap bit4;
        Bitmap bit5;
        Bitmap bit6;
        Bitmap bit7;
        Bitmap bit8;
        Bitmap bit9;
        protected override void OnLoad(EventArgs e)
        {
            bit = new Bitmap("거북왕1.gif");
            ImageAnimator.Animate(bit, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit1 = new Bitmap("chu13.gif");
            ImageAnimator.Animate(bit1, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit2 = new Bitmap("거북왕.gif");
            ImageAnimator.Animate(bit2, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit3 = new Bitmap("chu1.gif");
            ImageAnimator.Animate(bit3, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit4 = new Bitmap("chu5.gif");
            ImageAnimator.Animate(bit4, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit5 = new Bitmap("chu3.gif");
            ImageAnimator.Animate(bit5, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit6 = new Bitmap("chu4.gif");
            ImageAnimator.Animate(bit6, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit7 = new Bitmap("turtle.gif");//거북왕 용의 파동
            ImageAnimator.Animate(bit7, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit8 = new Bitmap("turtle1.gif");//거북왕 물대포
            ImageAnimator.Animate(bit8, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);


            bit9 = new Bitmap("turtle2.gif");//거북왕 고속스핀
            ImageAnimator.Animate(bit9, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            

            ImageAnimator.UpdateFrames();
            Graphics h = pictureBox3.CreateGraphics();
            h.DrawImage(this.bit1, new Point(15, 10));
            base.OnPaint(e);

            ImageAnimator.UpdateFrames();
            Graphics t = pictureBox4.CreateGraphics();
            t.DrawImage(this.bit2, new Point(0, 0));
            base.OnPaint(e);

            Graphics y = pictureBox2.CreateGraphics();
            if (number == 0)
            {
                ImageAnimator.UpdateFrames();
                y.DrawImage(this.bit, new Point(-50, 0));//거북왕 대기화면
                base.OnPaint(e);
            }
            else if (number == 1)
            {
                ImageAnimator.UpdateFrames();
                y.DrawImage(this.bit7, new Point(-50, 0));//거북왕 용의 파동
                base.OnPaint(e);
            }
            else if (number == 2)
            {
                ImageAnimator.UpdateFrames();
                y.DrawImage(this.bit8, new Point(-50, 0)); //거북왕 물대포
                base.OnPaint(e);
            }
            else
            {
                ImageAnimator.UpdateFrames();
                y.DrawImage(this.bit9, new Point(-50, 0));//거북왕 고속스핀
                base.OnPaint(e);
            }

            Graphics x = pictureBox1.CreateGraphics();
            if (number == 0)
            {
                ImageAnimator.UpdateFrames();                
                x.DrawImage(this.bit3, new Point(-70, 0));//피카츄 대기화면
                base.OnPaint(e);
            }
            else if (number == 1)
            {
                ImageAnimator.UpdateFrames();
                x.DrawImage(this.bit4, new Point(-50, 0));//피카츄 아이언테일
                base.OnPaint(e);
            }
            else if (number == 2)
            {
                ImageAnimator.UpdateFrames();
                x.DrawImage(this.bit5, new Point(-50, 0));//피카츄 전광석화
                base.OnPaint(e);
            }
            else
            {
                ImageAnimator.UpdateFrames();
                x.DrawImage(this.bit6, new Point(-50, 0));//피카츄 백만볼트
                base.OnPaint(e);
            }

        }
        private void OnFrameChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = 1;
            progressBar1.Step = -10;
            progressBar1.PerformStep();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number = 2;
            progressBar1.Step = -5;
            progressBar1.PerformStep();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number = 3;
            progressBar1.Step = -20;
            progressBar1.PerformStep();
           
        }
    }
}
