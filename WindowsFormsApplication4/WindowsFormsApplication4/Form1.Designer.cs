namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Eat = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.State = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sleep = new System.Windows.Forms.Button();
            this.Hunt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Eat
            // 
            this.Eat.Location = new System.Drawing.Point(13, 214);
            this.Eat.Name = "Eat";
            this.Eat.Size = new System.Drawing.Size(75, 23);
            this.Eat.TabIndex = 0;
            this.Eat.Text = "먹기";
            this.Eat.UseVisualStyleBackColor = true;
            this.Eat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(197, 214);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 2;
            this.Play.Text = "놀아주기";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // State
            // 
            this.State.Location = new System.Drawing.Point(12, 9);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(260, 190);
            this.State.TabIndex = 3;
            this.State.Text = "State";
            this.State.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(278, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Sleep
            // 
            this.Sleep.Location = new System.Drawing.Point(107, 214);
            this.Sleep.Name = "Sleep";
            this.Sleep.Size = new System.Drawing.Size(75, 23);
            this.Sleep.TabIndex = 5;
            this.Sleep.Text = "자기";
            this.Sleep.UseVisualStyleBackColor = true;
            this.Sleep.Click += new System.EventHandler(this.Sleep_Click);
            // 
            // Hunt
            // 
            this.Hunt.Location = new System.Drawing.Point(278, 243);
            this.Hunt.Name = "Hunt";
            this.Hunt.Size = new System.Drawing.Size(183, 28);
            this.Hunt.TabIndex = 6;
            this.Hunt.Text = "사냥하기";
            this.Hunt.UseVisualStyleBackColor = true;
            this.Hunt.Click += new System.EventHandler(this.Hunt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 368);
            this.Controls.Add(this.Hunt);
            this.Controls.Add(this.Sleep);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.State);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Eat);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Eat;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Sleep;
        private System.Windows.Forms.Button Hunt;
    }
}

