using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        Chu chu = new Chu();
        int EatCount = 0;
        int SleepCount = 0;
        int PlayCount = 0;

        Form2 HuntScreen = new Form2();
        public Form1()
        {
            InitializeComponent();
            State.Text = "주인님 뭘 할까요 ??";
            
        }
        //Bitmap bit;
        //protected override void OnLoad(EventArgs e)//gif 출력 코딩퍼옴 https://m.blog.naver.com/PostView.nhn?blogId=goldrushing&logNo=130184365511&proxyReferer=https%3A%2F%2Fwww.google.co.kr%2F
        //{
        //    bit = new Bitmap("chu13.gif");//gif 나오게 하기
        //    ImageAnimator.Animate(bit, new EventHandler(this.OnFrameChanged));
        //    base.OnLoad(e);
        //}
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    ImageAnimator.UpdateFrames();
        //    Graphics g = pictureBox1.CreateGraphics();
        //    g.DrawImage(this.bit, new Point(15, 10));//3D피카츄의 picturebox에서의 위치를 정해준다
        //    base.OnPaint(e);
        //}
        //private void OnFrameChanged(object sender, EventArgs e)
        //{
        //    this.Invalidate();
        //}
    

private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var src = (Bitmap)Bitmap.FromFile("eat1.jpg");

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
            pictureBox1.Image = tgt;
            

            State.Text = "냠냠 맛있쪙~♥";
            EatCount++;

            if (EatCount > 3)
            {


                State.Text = "주인님 그만 먹고 싶어요 ㅠㅠㅠ";
                var src1 = (Bitmap)Bitmap.FromFile("eat.jpg");

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
                pictureBox1.Image = tgt1;

                chu.Eat();
                Eat.Enabled = false;
            }
        }

        private void Sleep_Click(object sender, EventArgs e)
        {
            
            State.Text = "주인.....ㄴㅣㅁzzzzZZZZZZZ";
            
            SleepCount++;

            //if (SleepCount >= 1)
            //    State.Text = "피카츄는 이미 자고 있는 중 입니다 !!";// 피카츄 sleep눌렀을때 출력하게 하고 싶음

           
            
            Eat.Enabled = false;
            Play.Enabled = false;
            Sleep.Enabled = false;

            Thread.Sleep(3000);
           

            Eat.Enabled = true;
            Play.Enabled = true;
            Sleep.Enabled = true;
            
            chu.Sleep();

            EatCount = 0;//Sleep버튼을 눌렀을때 EatCount를 0으로 초기화시킨다

        }

        private void Play_Click(object sender, EventArgs e)
        {
            State.Text = "주인님은 이런 놀이를 좋아하시는군요 ??";
            PlayCount++;
            Eat.Enabled = true;

            var src1 = (Bitmap)Bitmap.FromFile("PLAY.jpg");

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
            pictureBox1.Image = tgt1;

            if (PlayCount > 3)
                State.Text = "주인님 이제 이건 재미없어요.. 색다른거 없나요...♥";

            EatCount = 0;//Play버튼을 눌렀을때 EatCount를 0으로 초기화시킨다
        }

        private void Hunt_Click(object sender, EventArgs e)
        {
            HuntScreen.ShowDialog();
        }

        private void chu3D_Click(object sender, EventArgs e)
        {

        }

        private void chu3D_Click_1(object sender, EventArgs e)
        {

        }
    }
}
