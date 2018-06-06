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
    
    public partial class Form6 : Form
    {
        int number = 0;
        int skillcount1 = 0;
        int skillcount2 = 0;
        int skillcount3 = 0;
        public Form6()
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
            bit = new Bitmap("리자몽 1.gif");
            ImageAnimator.Animate(bit, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit1 = new Bitmap("chu13.gif");
            ImageAnimator.Animate(bit1, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit2 = new Bitmap("리자몽.gif");
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

            bit7 = new Bitmap("에어 슬래시.gif");
            ImageAnimator.Animate(bit7, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit8 = new Bitmap("화염방사.gif");
            ImageAnimator.Animate(bit8, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit9 = new Bitmap("화염소용돌이.gif");
            ImageAnimator.Animate(bit9, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames();
            Graphics h = pictureBox3.CreateGraphics();//초기 picturebox3에 뜨는 gif
            h.DrawImage(this.bit1, new Point(15, 10));
            base.OnPaint(e);

            ImageAnimator.UpdateFrames();
            Graphics t = pictureBox4.CreateGraphics();//초기 picturebox4에 뜨는 gif
            t.DrawImage(this.bit2, new Point(-10, -20));
            base.OnPaint(e);

            Graphics y = pictureBox1.CreateGraphics();
            if (number == 0)
            {
                ImageAnimator.UpdateFrames();
                y.DrawImage(this.bit3, new Point(-50, 0));//초기 picturebox1에 뜨는 gif
                base.OnPaint(e);
            }
            else if (number == 1)
            {
                ImageAnimator.UpdateFrames();
                y.DrawImage(this.bit4, new Point(0, 0));//피카츄 아이언테일 사용 시 picturebox1에 뜨는 gif
                base.OnPaint(e);
            }
            else if (number == 2)
            {
                ImageAnimator.UpdateFrames();
                y.DrawImage(this.bit5, new Point(0, 0));//피카츄 전광석화 사용 시 picturebox1에 뜨는 gif
                base.OnPaint(e);
            }
            else
            {
                ImageAnimator.UpdateFrames();
                y.DrawImage(this.bit6, new Point(0, 0));//피카츄 백만볼트 사용 시 picturebox1에 뜨는 gif
                base.OnPaint(e);
            }
            Graphics g = pictureBox2.CreateGraphics();
            if (number == 0) { 
            ImageAnimator.UpdateFrames();
            g.DrawImage(this.bit, new Point(0, 0));//초기 picturebox2에 뜨는 gif
            base.OnPaint(e);
        }
            else if (number == 1)
            {
                ImageAnimator.UpdateFrames();
                g.DrawImage(this.bit7, new Point(0, 0));//피카츄 아이언테일 사용 시 pciturebox2에 뜨는 gif
                base.OnPaint(e);
            }
            else if (number == 2)
            {
                ImageAnimator.UpdateFrames();
                g.DrawImage(this.bit8, new Point(0, 0));//피카츄 전광석화 사용 시 pciturebox2에 뜨는 gif
                base.OnPaint(e);
            }
            else
            {
                ImageAnimator.UpdateFrames();
                g.DrawImage(this.bit9, new Point(0, 0));//피카츄 백만볼트 사용 시 pciturebox2에 뜨는 gif
                base.OnPaint(e);
            }
        }
        private void OnFrameChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = 1;
            skillcount2 = 0;
            skillcount3 = 0;
            button2.Enabled = true;
            button3.Enabled = true;
            timer1.Enabled = true;//리자몽 스킬 사용 시 타이머 불작동 방지

            if (skillcount1 == 0)
            {
                State.Text = "피카츄 아이언테일 !!... 효과가 굉장했다 !";
                progressBar1.Step = -10;//피카츄 아이언테일 사용 시 리자몽 체력바 다는 정도 
                progressBar1.PerformStep();
            }
            else if (skillcount1 == 1)
            {
                State.Text = "피카츄 아이언테일 !!... 효과가 굉장했다 !";
                progressBar1.Step = -10;//피카츄 아이언테일 사용 시 리자몽 체력바 다는 정도 
                progressBar1.PerformStep();
            }
            else if (skillcount1 == 2)
            {
                State.Text = "피카츄 아이언테일 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//피카츄 아이언테일 사용 시 리자몽 체력바 다는 정도 
                progressBar1.PerformStep();

            }
            else
            {
                State.Text = "피카츄 아이언테일 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//피카츄 아이언테일 사용 시 리자몽 체력바 다는 정도 
                progressBar1.PerformStep();
                button1.Enabled = false;
            }
            skillcount1++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            number = 2;
            skillcount1 = 0;
            skillcount3 = 0;
            button1.Enabled = true;
            button3.Enabled = true;
            timer1.Enabled = true;

            if (skillcount2 == 0)
            {
                State.Text = "피카츄 전광석화 !!... 효과가 굉장했다 !";
                progressBar1.Step = -10;//피카츄 전광석화 사용 시 리자몽 체력바 다는 정도 
                progressBar1.PerformStep();
            }
            else if (skillcount2 == 1)
            {
                State.Text = "피카츄 전광석화 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//피카츄 전광석화 사용 시 리자몽 체력바 다는 정도 
                progressBar1.PerformStep();
            }
            else if (skillcount2 == 2)
            {
                State.Text = "피카츄 전광석화 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//피카츄 전광석화 사용 시 리자몽 체력바 다는 정도 
                progressBar1.PerformStep();

            }
            else if (skillcount2 == 3)
            {
                State.Text = "피카츄 전광석화 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//피카츄 전광석화 사용 시 리자몽 체력바 다는 정도 
                progressBar1.PerformStep();
            }
            else
            {
                State.Text = "피카츄 전광석화 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//피카츄 전광석화 사용 시 리자몽 체력바 다는 정도 
                progressBar1.PerformStep();
                button2.Enabled = false;
            }
            skillcount2++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            number = 3;
            skillcount1 = 0;
            skillcount2 = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            timer1.Enabled = true;
            if (skillcount3 == 0)
            {
                State.Text = "피카츄 백만볼트 !!... 효과가 굉장했다 !";
                progressBar1.Step = -20;//피카츄 백만볼트 사용 시 리자몽 체력바 다는 정도 
                progressBar1.PerformStep();
            }
            else if (skillcount3 == 1)
            {
                State.Text = "피카츄 백만볼트 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -10;//피카츄 백만볼트 사용 시 리자몽 체력바 다는 정도 
                progressBar1.PerformStep();
            }
            else
            {
                button3.Enabled = false;

            }

            skillcount3++;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (number == 0)
            {
                State.Text = "크아아아아아";
                timer1.Enabled = false;
            }
            else if (number == 1)
            {
                State.Text = "리자몽이 <에어슬레시>를 사용했다!!... ";
                timer1.Enabled = false;
                progressBar2.Step = -10;//리자몽 에어슬레시 사용 시 피카츄 체력바 다는 정도
                progressBar2.PerformStep();
            }
            else if (number == 2)
            {
                State.Text = "리자몽이 <화염방사>를 사용했다!!...";
                timer1.Enabled = false;
                progressBar2.Step = -10;//리자몽 화염방사 사용 시 피카츄 체력바 다는 정도
                progressBar2.PerformStep();
            }
            else
            {
                State.Text = "리자몽이 <화염소용돌이>을 사용했다!!...";
                timer1.Enabled = false;
                progressBar2.Step = -10;//리자몽 화염소용돌이 사용 시 피카츄 체력바 다는 정도
                progressBar2.PerformStep();
            }
        }
    }
}
