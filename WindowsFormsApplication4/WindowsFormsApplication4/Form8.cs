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
    public partial class Form8 : Form
    {       
        int number = 0;
        int skillcount1 = 0;
        int skillcount2 = 0;
        int skillcount3 = 0;
        public Form8()
        {
            InitializeComponent();
            progressBar1.Value = 100;//초기 앤테이 체력바 100
            progressBar2.Value = 100;//초기 피카츄 체력바 100
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
            bit = new Bitmap("chu13.gif");
            ImageAnimator.Animate(bit, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit1 = new Bitmap("앤테이.gif");
            ImageAnimator.Animate(bit1, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit2 = new Bitmap("앤테이1.png");
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

            bit7 = new Bitmap("성스러운불꽃.gif");
            ImageAnimator.Animate(bit7, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit8 = new Bitmap("분연.gif");
            ImageAnimator.Animate(bit8, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);

            bit9 = new Bitmap("파괴광선1.gif");
            ImageAnimator.Animate(bit9, new EventHandler(this.OnFrameChanged));
            base.OnLoad(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames();
            Graphics g = pictureBox3.CreateGraphics();
            g.DrawImage(this.bit, new Point(15, 10));//chu 13, 초기 picturebox3에 뜨는 gif
            base.OnPaint(e);



            ImageAnimator.UpdateFrames();
            Graphics t = pictureBox4.CreateGraphics();
            t.DrawImage(this.bit2, new Point(0, 0));//앤테이 1, 초기 picturebox4에 뜨는 gif
            base.OnPaint(e);



            Graphics y = pictureBox1.CreateGraphics();
            if (number == 0)
            {
                ImageAnimator.UpdateFrames();
                y.DrawImage(this.bit3, new Point(-50, 0));//chu 1, 초기 picturebox1에 뜨는 gif
                base.OnPaint(e);
            }
            else if (number == 1)
            {
                ImageAnimator.UpdateFrames();
                y.DrawImage(this.bit4, new Point(0, 0));//chu 5, 피카츄 아이언테일 사용 시 picturebox1에 뜨는 gif
                base.OnPaint(e);


            }
            else if (number == 2)
            {
                ImageAnimator.UpdateFrames();
                y.DrawImage(this.bit5, new Point(0, 0));//chu 3, 피카츄 전광석화 사용 시 picturebox에 뜨는 gif
                base.OnPaint(e);
            }
            else
            {
                ImageAnimator.UpdateFrames();
                y.DrawImage(this.bit6, new Point(0, 0));//chu 4, 피카츄 백만볼트 사용 시 picturebox에 뜨는 gif
                base.OnPaint(e);
            }

            Graphics h = pictureBox2.CreateGraphics();
            if (number == 0)
            {
                ImageAnimator.UpdateFrames();
                h.DrawImage(this.bit1, new Point(0, 0));//앤테이, 초기 picturebox2에 뜨는 gif
                base.OnPaint(e);
            }
            else if (number == 1)
            {
                ImageAnimator.UpdateFrames();
                h.DrawImage(this.bit7, new Point(0, 0));//성스러운불꽃, 피카츄 아이언테일 사용 시 picturebox2에 뜨는 gif
                base.OnPaint(e);
            }
            else if (number == 2)
            {
                ImageAnimator.UpdateFrames();
                h.DrawImage(this.bit8, new Point(0, 0));//분연, 피카츄 전광석화 사용 시 picturebox2에 뜨는 gif
                base.OnPaint(e);
            }
            else
            {
                ImageAnimator.UpdateFrames();
                h.DrawImage(this.bit9, new Point(0, 0));//파괴광선1, 피카츄 백만볼트 사용 시 picturebox2에 뜨는 gif
                base.OnPaint(e);
            }



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


    

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

     

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
   

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            number = 1;
            skillcount2 = 0;
            skillcount3 = 0;
            button2.Enabled = true;
            button3.Enabled = true;
            timer1.Enabled = true;//앤테이 스킬 사용 시 타이머 비작동 방지

            if (skillcount1 == 0)
            {
                State.Text = "피카츄 아이언테일 !!... 효과가 굉장했다 !";
                progressBar1.Step = -10;//앤테이 체력바 다는 정도 
                progressBar1.PerformStep();
            }
            else if (skillcount1 == 1)
            {
                State.Text = "피카츄 아이언테일 !!... 효과가 굉장했다 !";
                progressBar1.Step = -10;//앤테이 체력바 다는 정도 
                progressBar1.PerformStep();
            }
            else if (skillcount1 == 2)
            {
                State.Text = "피카츄 아이언테일 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//앤테이 체력바 다는 정도 
                progressBar1.PerformStep();

            }
            else
            {
                State.Text = "피카츄 아이언테일 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//앤테이 체력바 다는 정도 
                progressBar1.PerformStep();
                button1.Enabled = false;
            }
            skillcount1++;

        }

        private void button2_Click_1(object sender, EventArgs e)
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
                progressBar1.Step = -10;//앤테이 체력바 다는 정도 
                progressBar1.PerformStep();
            }
            else if (skillcount2 == 1)
            {
                State.Text = "피카츄 전광석화 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//앤테이 체력바 다는 정도 
                progressBar1.PerformStep();
            }
            else if (skillcount2 == 2)
            {
                State.Text = "피카츄 전광석화 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//앤테이 체력바 다는 정도
                progressBar1.PerformStep();

            }
            else if (skillcount2 == 3)
            {
                State.Text = "피카츄 전광석화 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//앤테이 체력바 다는 정도
                progressBar1.PerformStep();
            }
            else
            {
                State.Text = "피카츄 전광석화 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//앤테이 체력바 다는 정도
                progressBar1.PerformStep();
                button2.Enabled = false;
            }
            skillcount2++;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            number = 3;
            skillcount1 = 0;
            skillcount2 = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            timer1.Enabled = true;
            if (skillcount3 == 0)
            {
                State.Text = "피카츄 백만볼트 !!... 효과가 굉장했다 !";//백만볼트 1번 사용시
                progressBar1.Step = -20;//앤테이 체력바 다는 정도
                progressBar1.PerformStep();
            }
            else if (skillcount3 == 1)
            {
                State.Text = "피카츄 백만볼트 !!... 효과가 별로였다 ,,,";//백만볼트 2번 사용시
                progressBar1.Step = -10;//앤테이 체력바 다는 정도
                progressBar1.PerformStep();
            }
            else
            {
                button3.Enabled = false;

            }

            skillcount3++;


        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (number == 0)
            {
                State.Text = "크아아아아아";
                timer1.Enabled = false;//타이머 작동 멈춤
            }
            else if (number == 1)
            {
                State.Text = "앤테이가 <성스러운불꽃>를 사용했다!!... ";
                timer1.Enabled = false;//타이머 작동 멈춤
                progressBar2.Step = -10;
                progressBar2.PerformStep();
            }
            else if (number == 2)
            {
                State.Text = "앤테이가 <분연>를 사용했다!!...";
                timer1.Enabled = false;//타이머 작동 멈춤
                progressBar2.Step = -10;
                progressBar2.PerformStep();
            }
            else
            {
                State.Text = "앤테이가 <파괴광선>을 사용했다!!...";
                timer1.Enabled = false;//타이머 작동 멈춤
                progressBar2.Step = -10;
                progressBar2.PerformStep();
            }
        }
    }
}

