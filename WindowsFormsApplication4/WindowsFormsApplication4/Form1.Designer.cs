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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Eat
            // 
            this.Eat.BackColor = System.Drawing.SystemColors.Window;
            this.Eat.Font = new System.Drawing.Font("HY수평선B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Eat.Location = new System.Drawing.Point(12, 276);
            this.Eat.Name = "Eat";
            this.Eat.Size = new System.Drawing.Size(84, 80);
            this.Eat.TabIndex = 0;
            this.Eat.Text = "먹기";
            this.Eat.UseVisualStyleBackColor = false;
            this.Eat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.Window;
            this.Play.Font = new System.Drawing.Font("HY수평선B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Play.Location = new System.Drawing.Point(189, 276);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(83, 80);
            this.Play.TabIndex = 2;
            this.Play.Text = "놀아주기";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // State
            // 
            this.State.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.State.Location = new System.Drawing.Point(12, 42);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(260, 228);
            this.State.TabIndex = 3;
            this.State.Text = "State";
            this.State.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(278, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Sleep
            // 
            this.Sleep.BackColor = System.Drawing.SystemColors.Window;
            this.Sleep.Font = new System.Drawing.Font("HY수평선B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Sleep.Location = new System.Drawing.Point(102, 276);
            this.Sleep.Name = "Sleep";
            this.Sleep.Size = new System.Drawing.Size(81, 80);
            this.Sleep.TabIndex = 5;
            this.Sleep.Text = "자기";
            this.Sleep.UseVisualStyleBackColor = false;
            this.Sleep.Click += new System.EventHandler(this.Sleep_Click);
            // 
            // Hunt
            // 
            this.Hunt.BackColor = System.Drawing.SystemColors.Menu;
            this.Hunt.Font = new System.Drawing.Font("HY수평선B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Hunt.Location = new System.Drawing.Point(278, 271);
            this.Hunt.Name = "Hunt";
            this.Hunt.Size = new System.Drawing.Size(220, 28);
            this.Hunt.TabIndex = 6;
            this.Hunt.Text = "사냥하기";
            this.Hunt.UseVisualStyleBackColor = false;
            this.Hunt.Click += new System.EventHandler(this.Hunt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(44, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox3.Location = new System.Drawing.Point(443, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 35);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(510, 368);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Hunt);
            this.Controls.Add(this.Sleep);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.State);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Eat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Eat;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Sleep;
        private System.Windows.Forms.Button Hunt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
    }
}

