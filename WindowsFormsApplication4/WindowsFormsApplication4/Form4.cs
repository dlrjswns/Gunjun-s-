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
        int skillcount1 = 0;
        int skillcount2 = 0;
        int skillcount3 = 0;
        public Form4()
        {
            InitializeComponent();
            progressBar1.Value = 100;//거북왕 초기 체력바 100
            progressBar2.Value = 100;//피카츄 초기 체력바 100
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
            pictureBox5.Image = tgt;

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
            Graphics h = pictureBox3.CreateGraphics();//초기 picturebox3에 뜨는 gif
            h.DrawImage(this.bit1, new Point(15, 10));
            base.OnPaint(e);

            ImageAnimator.UpdateFrames();
            Graphics t = pictureBox4.CreateGraphics();//초기 picturebox4에 뜨는 gif
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
                x.DrawImage(this.bit3, new Point(-50, 0));//피카츄 대기화면
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
                x.DrawImage(this.bit5, new Point(-70, 0));//피카츄 전광석화
                base.OnPaint(e);
            }
            else
            {
                ImageAnimator.UpdateFrames();
                x.DrawImage(this.bit6, new Point(-70, 0));//피카츄 백만볼트
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
            skillcount2 = 0;
            skillcount3 = 0;
            button2.Enabled = true;
            button3.Enabled = true;
            timer1.Enabled = true;

            if (skillcount1 == 0)
            {
                State.Text = "피카츄 아이언테일 !!... 효과가 굉장했다 !";
                progressBar1.Step = -10;//거북왕 체력바 다는 정도
                progressBar1.PerformStep();
            }
            else if (skillcount1 == 1)
            {
                State.Text = "피카츄 아이언테일 !!... 효과가 굉장했다 !";
                progressBar1.Step = -10;//거북왕 체력바 다는 정도
                progressBar1.PerformStep();
            }
            else if (skillcount1 == 2)
            {
                State.Text = "피카츄 아이언테일 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//거북왕 체력바 다는 정도
                progressBar1.PerformStep();

            }
            else
            {
                State.Text = "피카츄 아이언테일 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//거북왕 체력바 다는 정도
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
                progressBar1.Step = -10;//거북왕 체력바 다는 정도
                progressBar1.PerformStep();
            }
            else if (skillcount2 == 1)
            {
                State.Text = "피카츄 전광석화 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//거북왕 체력바 다는 정도
                progressBar1.PerformStep();
            }
            else if (skillcount2 == 2)
            {
                State.Text = "피카츄 전광석화 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//거북왕 체력바 다는 정도
                progressBar1.PerformStep();

            }
            else if (skillcount2 == 3)
            {
                State.Text = "피카츄 전광석화 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//거북왕 체력바 다는 정도
                progressBar1.PerformStep();
            }
            else
            {
                State.Text = "피카츄 전광석화 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -5;//거북왕 체력바 다는 정도
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
                progressBar1.Step = -20;//거북왕 체력바 다는 정도
                progressBar1.PerformStep();
            }
            else if (skillcount3 == 1)
            {
                State.Text = "피카츄 백만볼트 !!... 효과가 별로였다 ,,,";
                progressBar1.Step = -10;//거북왕 체력바 다는 정도
                progressBar1.PerformStep();
            }
            else
            {
                button3.Enabled = false;//피카츄 백만볼트 스킬 2번 이상 사용시 사용 금지

            }

            skillcount3++;


        }
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (number == 0)
            {
               
            }
            else if (number == 1)
            {
                State.Text = "거북왕이 <용의 분노>를 사용했다!!... ";
                timer1.Enabled = false;
                progressBar2.Step = -10;//거북왕 용의분노 사용 시 피카츄 체력바 다는 정도
                progressBar2.PerformStep();
            }
            else if (number == 2)
            {
                State.Text = "거북왕이 <물대포>를 사용했다!!...";
                timer1.Enabled = false;
                progressBar2.Step = -10;//거북왕 물대포 사용 시 피카츄 체력바 다는 정도
                progressBar2.PerformStep();
            }
            else
            {
                State.Text = "거북왕이 <고속스핀>을 사용했다!!...";
                timer1.Enabled = false;
                progressBar2.Step = -10;//거북왕 고속스핀 사용 시 피카츄 체력바 다는 정도
                progressBar2.PerformStep();
            }
            if (progressBar1.Value == 0)
            {
                timer1.Enabled = true;
                time++;
                State.Text = "야생의 거북왕이 쓰러졌습니다 !!";
                if (time == 2)
                {
                    timer1.Enabled = false;
                    this.Close();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
