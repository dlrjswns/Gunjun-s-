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
        Form3 where = new Form3();
        Form9 form9 = new Form9();
        public Form1()
        {
            InitializeComponent();
            State.Text = "주인님 뭘 할까요 ??";
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

            var src1 = (Bitmap)Bitmap.FromFile("종료.png");

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
            pictureBox3.Image = tgt1;

        }



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

            Play.Enabled = true;
            Sleep.Enabled = true;
            State.Text = "냠냠 맛있쪙~♥";
            EatCount++;//Eat버튼 누를때마다 eatcount 증가
            PlayCount = 0;//Eat버튼 누르면 playcount 초기화
            SleepCount = 0;//Eat버튼 누르면 sleepcount 초기화

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
            SleepCount++;
            State.Text = "주인.....ㄴㅣㅁzzzzZZZZZZZ";
            Play.Enabled = true;
            Eat.Enabled = true;

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
            PlayCount = 0;
            var src1 = (Bitmap)Bitmap.FromFile("sleep14.jpg");

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

            if (SleepCount > 1)
            {
                State.Text = "그만 자고 싶어요 ㅠㅠㅠㅠㅠㅜㅜ";
                var src2 = (Bitmap)Bitmap.FromFile("sleep13.jpg");

                // 소스이미지 크기와 동일한 타겟이미지 생성
                Bitmap tgt2 = new Bitmap(src2.Width, src2.Height);

                // 타겟이미지의 Graphics 객체 얻기        
                using (Graphics g = Graphics.FromImage(tgt2))
                {
                    // 배경색을 설정
                    var rect = new Rectangle(0, 0, tgt2.Width, tgt2.Height);
                    using (Brush br = new SolidBrush(SystemColors.Control))
                    {
                        g.FillRectangle(br, 0, 0, tgt2.Width, tgt2.Height);
                    }
                    // 소스이미지를 원모양으로 잘라 타겟이미지에 출력
                    g.DrawImage(src2, 0, 0);
                }
                // PictureBox에 이미지 출력
                pictureBox1.Image = tgt2;

                chu.Eat();
                Sleep.Enabled = false;
               

            }

        
        }



        private void Play_Click(object sender, EventArgs e)
        {
            State.Text = "주인님은 이런 놀이를 좋아하시는군요 ??";
            PlayCount++;
            Eat.Enabled = true;//play버튼을 눌렀을때 false되있는 다른 버튼의 enabled를 true로
            Sleep.Enabled = true;//play버튼을 눌렀을때 false되있는 다른 버튼의 enabled를 true로


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
            {
                State.Text = "주인님 이제 이건 재미없어요.. 색다른거 없나요...♥";
                Play.Enabled = false;
                var src3 = (Bitmap)Bitmap.FromFile("noplay.jpg");

                // 소스이미지 크기와 동일한 타겟이미지 생성
                Bitmap tgt3 = new Bitmap(src3.Width, src3.Height);

                // 타겟이미지의 Graphics 객체 얻기        
                using (Graphics g = Graphics.FromImage(tgt3))
                {
                    // 배경색을 설정
                    var rect = new Rectangle(0, 0, tgt3.Width, tgt3.Height);
                    using (Brush br = new SolidBrush(SystemColors.Control))
                    {
                        g.FillRectangle(br, 0, 0, tgt3.Width, tgt3.Height);
                    }
                    // 소스이미지를 원모양으로 잘라 타겟이미지에 출력
                    g.DrawImage(src3, 0, 0);
                }
                // PictureBox에 이미지 출력
                pictureBox1.Image = tgt3;

            }
            EatCount = 0;//Play버튼을 눌렀을때 EatCount를 0으로 초기화시킨다
            SleepCount = 0;
        }

        private void Hunt_Click(object sender, EventArgs e)
        {
            Visible = false;//사냥하기 버튼을 누를때 form1화면을 가려준다
           
            where.ShowDialog();//where폼을 보여준다
        }

        private void chu3D_Click(object sender, EventArgs e)
        {

        }

        private void chu3D_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
         

            Application.Exit();   //모든 윈폼 종료      
        }
    }
}
