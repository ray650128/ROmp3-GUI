namespace UpdateClient
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.btnSet = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkPokepe = new System.Windows.Forms.LinkLabel();
            this.linkBahamut = new System.Windows.Forms.LinkLabel();
            this.linkGNJOY = new System.Windows.Forms.LinkLabel();
            this.btnRunRO = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.titleBar = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtUpdLnk = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::UpdateClient.Properties.Resources.btn_null_off;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStart.Location = new System.Drawing.Point(361, 346);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 58);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "開始\r\n遊戲";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btnStart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(395, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(203, 245);
            this.textBox1.TabIndex = 3;
            // 
            // progBar
            // 
            this.progBar.ForeColor = System.Drawing.Color.Red;
            this.progBar.Location = new System.Drawing.Point(12, 324);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(586, 10);
            this.progBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progBar.TabIndex = 4;
            // 
            // btnSet
            // 
            this.btnSet.BackgroundImage = global::UpdateClient.Properties.Resources.btn_null_off;
            this.btnSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSet.Location = new System.Drawing.Point(523, 346);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 58);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "設定";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            this.btnSet.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btnSet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(12, 50);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(586, 245);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "更新內容：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkPokepe
            // 
            this.linkPokepe.AutoSize = true;
            this.linkPokepe.LinkColor = System.Drawing.Color.Green;
            this.linkPokepe.Location = new System.Drawing.Point(14, 387);
            this.linkPokepe.Name = "linkPokepe";
            this.linkPokepe.Size = new System.Drawing.Size(42, 12);
            this.linkPokepe.TabIndex = 8;
            this.linkPokepe.TabStop = true;
            this.linkPokepe.Text = "ROmp3";
            this.linkPokepe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPokepe_LinkClicked);
            this.linkPokepe.MouseLeave += new System.EventHandler(this.HyperLink_MouseLeave);
            this.linkPokepe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HyperLink_MouseMove);
            // 
            // linkBahamut
            // 
            this.linkBahamut.AutoSize = true;
            this.linkBahamut.LinkColor = System.Drawing.Color.Green;
            this.linkBahamut.Location = new System.Drawing.Point(62, 387);
            this.linkBahamut.Name = "linkBahamut";
            this.linkBahamut.Size = new System.Drawing.Size(53, 12);
            this.linkBahamut.TabIndex = 9;
            this.linkBahamut.TabStop = true;
            this.linkBahamut.Text = "巴哈姆特";
            this.linkBahamut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBahamut_LinkClicked);
            this.linkBahamut.MouseLeave += new System.EventHandler(this.HyperLink_MouseLeave);
            this.linkBahamut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HyperLink_MouseMove);
            // 
            // linkGNJOY
            // 
            this.linkGNJOY.AutoSize = true;
            this.linkGNJOY.LinkColor = System.Drawing.Color.Green;
            this.linkGNJOY.Location = new System.Drawing.Point(121, 387);
            this.linkGNJOY.Name = "linkGNJOY";
            this.linkGNJOY.Size = new System.Drawing.Size(41, 12);
            this.linkGNJOY.TabIndex = 10;
            this.linkGNJOY.TabStop = true;
            this.linkGNJOY.Text = "GNJOY";
            this.linkGNJOY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGNJOY_LinkClicked);
            this.linkGNJOY.MouseLeave += new System.EventHandler(this.HyperLink_MouseLeave);
            this.linkGNJOY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HyperLink_MouseMove);
            // 
            // btnRunRO
            // 
            this.btnRunRO.BackgroundImage = global::UpdateClient.Properties.Resources.btn_null_off;
            this.btnRunRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRunRO.FlatAppearance.BorderSize = 0;
            this.btnRunRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunRO.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRunRO.Location = new System.Drawing.Point(442, 346);
            this.btnRunRO.Name = "btnRunRO";
            this.btnRunRO.Size = new System.Drawing.Size(75, 58);
            this.btnRunRO.TabIndex = 11;
            this.btnRunRO.Text = "官方\r\n登入器";
            this.btnRunRO.UseVisualStyleBackColor = true;
            this.btnRunRO.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.btnRunRO.Click += new System.EventHandler(this.btnRunRO_Click);
            this.btnRunRO.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btnRunRO.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UpdateClient.Properties.Resources.titlebar_left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 17);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::UpdateClient.Properties.Resources.titlebar_right;
            this.pictureBox2.Location = new System.Drawing.Point(598, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 17);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // titleBar
            // 
            this.titleBar.BackgroundImage = global::UpdateClient.Properties.Resources.titlebar_mid;
            this.titleBar.Location = new System.Drawing.Point(5, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(600, 17);
            this.titleBar.TabIndex = 14;
            this.titleBar.TabStop = false;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::UpdateClient.Properties.Resources.sys_close_off;
            this.closeBtn.Location = new System.Drawing.Point(595, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(11, 11);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            this.closeBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
            this.closeBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseBtn_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::UpdateClient.Properties.Resources.btnbar_left;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(0, 340);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 71);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::UpdateClient.Properties.Resources.btnbar_right;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(589, 341);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 71);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::UpdateClient.Properties.Resources.btnbar_mid;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(12, 340);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(586, 71);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // txtUpdLnk
            // 
            this.txtUpdLnk.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdLnk.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUpdLnk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtUpdLnk.Location = new System.Drawing.Point(12, 298);
            this.txtUpdLnk.Name = "txtUpdLnk";
            this.txtUpdLnk.Size = new System.Drawing.Size(586, 23);
            this.txtUpdLnk.TabIndex = 19;
            this.txtUpdLnk.Text = "@null";
            this.txtUpdLnk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::UpdateClient.Properties.Resources.midbar_left;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(0, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(3, 334);
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::UpdateClient.Properties.Resources.midbar_right;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(607, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(3, 334);
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 411);
            this.Controls.Add(this.txtUpdLnk);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.btnRunRO);
            this.Controls.Add(this.linkGNJOY);
            this.Controls.Add(this.linkBahamut);
            this.Controls.Add(this.linkPokepe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROmp3 wide修正檔更新程式";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkPokepe;
        private System.Windows.Forms.LinkLabel linkBahamut;
        private System.Windows.Forms.LinkLabel linkGNJOY;
        private System.Windows.Forms.Button btnRunRO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox titleBar;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label txtUpdLnk;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

