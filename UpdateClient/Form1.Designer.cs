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
            this.txtUpdLnk = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.btnSet = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkPokepe = new System.Windows.Forms.LinkLabel();
            this.linkBahamut = new System.Windows.Forms.LinkLabel();
            this.linkGNJOY = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtUpdLnk
            // 
            this.txtUpdLnk.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUpdLnk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtUpdLnk.Location = new System.Drawing.Point(12, 316);
            this.txtUpdLnk.Name = "txtUpdLnk";
            this.txtUpdLnk.Size = new System.Drawing.Size(231, 37);
            this.txtUpdLnk.TabIndex = 0;
            this.txtUpdLnk.Text = "@null";
            this.txtUpdLnk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(249, 319);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "開始遊戲";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(393, 260);
            this.textBox1.TabIndex = 3;
            // 
            // progBar
            // 
            this.progBar.ForeColor = System.Drawing.Color.Red;
            this.progBar.Location = new System.Drawing.Point(12, 296);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(393, 17);
            this.progBar.TabIndex = 4;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(330, 319);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 50);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "設定";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(12, 30);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(393, 260);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "更新內容：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkPokepe
            // 
            this.linkPokepe.AutoSize = true;
            this.linkPokepe.LinkColor = System.Drawing.Color.Green;
            this.linkPokepe.Location = new System.Drawing.Point(10, 357);
            this.linkPokepe.Name = "linkPokepe";
            this.linkPokepe.Size = new System.Drawing.Size(42, 12);
            this.linkPokepe.TabIndex = 8;
            this.linkPokepe.TabStop = true;
            this.linkPokepe.Text = "ROmp3";
            this.linkPokepe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPokepe_LinkClicked);
            // 
            // linkBahamut
            // 
            this.linkBahamut.AutoSize = true;
            this.linkBahamut.LinkColor = System.Drawing.Color.Green;
            this.linkBahamut.Location = new System.Drawing.Point(58, 357);
            this.linkBahamut.Name = "linkBahamut";
            this.linkBahamut.Size = new System.Drawing.Size(53, 12);
            this.linkBahamut.TabIndex = 9;
            this.linkBahamut.TabStop = true;
            this.linkBahamut.Text = "巴哈姆特";
            this.linkBahamut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBahamut_LinkClicked);
            // 
            // linkGNJOY
            // 
            this.linkGNJOY.AutoSize = true;
            this.linkGNJOY.LinkColor = System.Drawing.Color.Green;
            this.linkGNJOY.Location = new System.Drawing.Point(117, 357);
            this.linkGNJOY.Name = "linkGNJOY";
            this.linkGNJOY.Size = new System.Drawing.Size(41, 12);
            this.linkGNJOY.TabIndex = 10;
            this.linkGNJOY.TabStop = true;
            this.linkGNJOY.Text = "GNJOY";
            this.linkGNJOY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGNJOY_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 381);
            this.Controls.Add(this.linkGNJOY);
            this.Controls.Add(this.linkBahamut);
            this.Controls.Add(this.linkPokepe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtUpdLnk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROmp3 wide修正檔更新程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtUpdLnk;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkPokepe;
        private System.Windows.Forms.LinkLabel linkBahamut;
        private System.Windows.Forms.LinkLabel linkGNJOY;
    }
}

