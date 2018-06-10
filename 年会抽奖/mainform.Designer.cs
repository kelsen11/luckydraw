namespace 年会抽奖
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonBeginStop = new System.Windows.Forms.Button();
            this.labelName1 = new System.Windows.Forms.Label();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelName3 = new System.Windows.Forms.Label();
            this.labelName4 = new System.Windows.Forms.Label();
            this.labelName5 = new System.Windows.Forms.Label();
            this.labelName6 = new System.Windows.Forms.Label();
            this.labelName7 = new System.Windows.Forms.Label();
            this.labelName8 = new System.Windows.Forms.Label();
            this.labelName9 = new System.Windows.Forms.Label();
            this.labelName10 = new System.Windows.Forms.Label();
            this.labelNameBig = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPrizeName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPrizeLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonBeginStop
            // 
            this.buttonBeginStop.BackColor = System.Drawing.Color.White;
            this.buttonBeginStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBeginStop.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBeginStop.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonBeginStop.Location = new System.Drawing.Point(628, 627);
            this.buttonBeginStop.Name = "buttonBeginStop";
            this.buttonBeginStop.Size = new System.Drawing.Size(135, 64);
            this.buttonBeginStop.TabIndex = 7;
            this.buttonBeginStop.Text = "开始";
            this.buttonBeginStop.UseVisualStyleBackColor = false;
            this.buttonBeginStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelName1
            // 
            this.labelName1.BackColor = System.Drawing.Color.Transparent;
            this.labelName1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName1.ForeColor = System.Drawing.Color.Moccasin;
            this.labelName1.Location = new System.Drawing.Point(47, 71);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(378, 41);
            this.labelName1.TabIndex = 8;
            this.labelName1.Text = "labelName1";
            this.labelName1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.BackColor = System.Drawing.Color.White;
            this.buttonNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNextPage.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonNextPage.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonNextPage.Location = new System.Drawing.Point(799, 636);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(114, 46);
            this.buttonNextPage.TabIndex = 9;
            this.buttonNextPage.Text = "下一项";
            this.buttonNextPage.UseVisualStyleBackColor = false;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(37, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "中奖名单：";
            // 
            // labelName2
            // 
            this.labelName2.BackColor = System.Drawing.Color.Transparent;
            this.labelName2.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName2.ForeColor = System.Drawing.Color.Moccasin;
            this.labelName2.Location = new System.Drawing.Point(49, 112);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(374, 41);
            this.labelName2.TabIndex = 13;
            this.labelName2.Text = "labelName2";
            this.labelName2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName3
            // 
            this.labelName3.BackColor = System.Drawing.Color.Transparent;
            this.labelName3.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName3.ForeColor = System.Drawing.Color.Moccasin;
            this.labelName3.Location = new System.Drawing.Point(49, 153);
            this.labelName3.Name = "labelName3";
            this.labelName3.Size = new System.Drawing.Size(374, 41);
            this.labelName3.TabIndex = 14;
            this.labelName3.Text = "labelName3";
            this.labelName3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName4
            // 
            this.labelName4.BackColor = System.Drawing.Color.Transparent;
            this.labelName4.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName4.ForeColor = System.Drawing.Color.Moccasin;
            this.labelName4.Location = new System.Drawing.Point(49, 194);
            this.labelName4.Name = "labelName4";
            this.labelName4.Size = new System.Drawing.Size(374, 41);
            this.labelName4.TabIndex = 15;
            this.labelName4.Text = "labelName4";
            this.labelName4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName5
            // 
            this.labelName5.BackColor = System.Drawing.Color.Transparent;
            this.labelName5.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName5.ForeColor = System.Drawing.Color.Moccasin;
            this.labelName5.Location = new System.Drawing.Point(49, 235);
            this.labelName5.Name = "labelName5";
            this.labelName5.Size = new System.Drawing.Size(374, 41);
            this.labelName5.TabIndex = 16;
            this.labelName5.Text = "labelName5";
            this.labelName5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName6
            // 
            this.labelName6.BackColor = System.Drawing.Color.Transparent;
            this.labelName6.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName6.ForeColor = System.Drawing.Color.Moccasin;
            this.labelName6.Location = new System.Drawing.Point(49, 276);
            this.labelName6.Name = "labelName6";
            this.labelName6.Size = new System.Drawing.Size(374, 41);
            this.labelName6.TabIndex = 17;
            this.labelName6.Text = "labelName6";
            this.labelName6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName7
            // 
            this.labelName7.BackColor = System.Drawing.Color.Transparent;
            this.labelName7.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName7.ForeColor = System.Drawing.Color.Moccasin;
            this.labelName7.Location = new System.Drawing.Point(49, 317);
            this.labelName7.Name = "labelName7";
            this.labelName7.Size = new System.Drawing.Size(374, 41);
            this.labelName7.TabIndex = 18;
            this.labelName7.Text = "labelName7";
            this.labelName7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName8
            // 
            this.labelName8.BackColor = System.Drawing.Color.Transparent;
            this.labelName8.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName8.ForeColor = System.Drawing.Color.Moccasin;
            this.labelName8.Location = new System.Drawing.Point(49, 358);
            this.labelName8.Name = "labelName8";
            this.labelName8.Size = new System.Drawing.Size(374, 41);
            this.labelName8.TabIndex = 19;
            this.labelName8.Text = "labelName8";
            this.labelName8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName9
            // 
            this.labelName9.BackColor = System.Drawing.Color.Transparent;
            this.labelName9.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName9.ForeColor = System.Drawing.Color.Moccasin;
            this.labelName9.Location = new System.Drawing.Point(49, 399);
            this.labelName9.Name = "labelName9";
            this.labelName9.Size = new System.Drawing.Size(374, 41);
            this.labelName9.TabIndex = 20;
            this.labelName9.Text = "labelName9";
            this.labelName9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName10
            // 
            this.labelName10.BackColor = System.Drawing.Color.Transparent;
            this.labelName10.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName10.ForeColor = System.Drawing.Color.Moccasin;
            this.labelName10.Location = new System.Drawing.Point(49, 440);
            this.labelName10.Name = "labelName10";
            this.labelName10.Size = new System.Drawing.Size(374, 41);
            this.labelName10.TabIndex = 21;
            this.labelName10.Text = "labelName10";
            this.labelName10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNameBig
            // 
            this.labelNameBig.BackColor = System.Drawing.Color.Transparent;
            this.labelNameBig.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNameBig.ForeColor = System.Drawing.Color.Moccasin;
            this.labelNameBig.Location = new System.Drawing.Point(-40, 235);
            this.labelNameBig.Name = "labelNameBig";
            this.labelNameBig.Size = new System.Drawing.Size(555, 82);
            this.labelNameBig.TabIndex = 22;
            this.labelNameBig.Text = "labelNameBig";
            this.labelNameBig.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::年会抽奖.Resource1.picPrize;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(586, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::年会抽奖.Resource1.picNameList;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelNameBig);
            this.panel1.Controls.Add(this.labelName8);
            this.panel1.Controls.Add(this.labelName5);
            this.panel1.Controls.Add(this.labelName1);
            this.panel1.Controls.Add(this.labelName2);
            this.panel1.Controls.Add(this.labelName3);
            this.panel1.Controls.Add(this.labelName4);
            this.panel1.Controls.Add(this.labelName6);
            this.panel1.Controls.Add(this.labelName10);
            this.panel1.Controls.Add(this.labelName7);
            this.panel1.Controls.Add(this.labelName9);
            this.panel1.Location = new System.Drawing.Point(52, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 530);
            this.panel1.TabIndex = 30;
            // 
            // labelPrizeName
            // 
            this.labelPrizeName.BackColor = System.Drawing.Color.Transparent;
            this.labelPrizeName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPrizeName.ForeColor = System.Drawing.Color.Moccasin;
            this.labelPrizeName.Location = new System.Drawing.Point(519, 178);
            this.labelPrizeName.Name = "labelPrizeName";
            this.labelPrizeName.Size = new System.Drawing.Size(493, 50);
            this.labelPrizeName.TabIndex = 31;
            this.labelPrizeName.Text = "iPhoneX 1部";
            this.labelPrizeName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.Moccasin;
            this.labelTitle.Location = new System.Drawing.Point(52, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(918, 82);
            this.labelTitle.TabIndex = 32;
            this.labelTitle.Text = "labelTitle";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPrizeLevel
            // 
            this.labelPrizeLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelPrizeLevel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPrizeLevel.ForeColor = System.Drawing.Color.Moccasin;
            this.labelPrizeLevel.Location = new System.Drawing.Point(519, 138);
            this.labelPrizeLevel.Name = "labelPrizeLevel";
            this.labelPrizeLevel.Size = new System.Drawing.Size(493, 35);
            this.labelPrizeLevel.TabIndex = 33;
            this.labelPrizeLevel.Text = "特等奖";
            this.labelPrizeLevel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = global::年会抽奖.Resource1.bg_red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.labelPrizeLevel);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelPrizeName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.buttonBeginStop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "LuckyDraw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonBeginStop;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelName3;
        private System.Windows.Forms.Label labelName4;
        private System.Windows.Forms.Label labelName5;
        private System.Windows.Forms.Label labelName6;
        private System.Windows.Forms.Label labelName7;
        private System.Windows.Forms.Label labelName8;
        private System.Windows.Forms.Label labelName9;
        private System.Windows.Forms.Label labelName10;
        private System.Windows.Forms.Label labelNameBig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPrizeName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPrizeLevel;
    }
}

