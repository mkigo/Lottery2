namespace Lottery
{
    partial class FormPrize
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrize));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnInitPool = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.picEmp = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWait = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmbPrize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSoftUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.滚动速度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(392, 539);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 27);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "抽 奖";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(508, 539);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(82, 27);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停 止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnInitPool
            // 
            this.btnInitPool.Location = new System.Drawing.Point(276, 539);
            this.btnInitPool.Name = "btnInitPool";
            this.btnInitPool.Size = new System.Drawing.Size(82, 27);
            this.btnInitPool.TabIndex = 0;
            this.btnInitPool.Text = "初始化奖池";
            this.btnInitPool.UseVisualStyleBackColor = true;
            this.btnInitPool.Click += new System.EventHandler(this.btnInitPool_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(498, 474);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(191, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "滚动速度：";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmpName.Location = new System.Drawing.Point(397, 394);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(72, 20);
            this.lblEmpName.TabIndex = 0;
            this.lblEmpName.Text = "王晓宇";
            // 
            // picEmp
            // 
            this.picEmp.Location = new System.Drawing.Point(369, 261);
            this.picEmp.Name = "picEmp";
            this.picEmp.Size = new System.Drawing.Size(128, 128);
            this.picEmp.TabIndex = 7;
            this.picEmp.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Lottery.Properties.Resources.bg1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.lblWait);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 217);
            this.panel1.TabIndex = 6;
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.BackColor = System.Drawing.Color.Transparent;
            this.lblWait.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWait.ForeColor = System.Drawing.Color.White;
            this.lblWait.Location = new System.Drawing.Point(307, 7);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(253, 29);
            this.lblWait.TabIndex = 0;
            this.lblWait.Text = "正在抽奖，请稍后";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(252, 36);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(375, 29);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "恭喜 李世民 获得一等奖！";
            this.lblResult.Visible = false;
            // 
            // cmbPrize
            // 
            this.cmbPrize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrize.FormattingEnabled = true;
            this.cmbPrize.Items.AddRange(new object[] {
            "特等奖",
            "一等奖",
            "二等奖",
            "三等奖",
            "四等奖",
            "五等奖",
            "纪念奖"});
            this.cmbPrize.Location = new System.Drawing.Point(300, 477);
            this.cmbPrize.Name = "cmbPrize";
            this.cmbPrize.Size = new System.Drawing.Size(121, 20);
            this.cmbPrize.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "奖金等级：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Lottery.Properties.Resources.Menubg;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelp,
            this.toolStripMenuItemSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDoc,
            this.toolStripMenuItemSoftUpdate,
            this.toolStripMenuItemAuthor});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItemHelp.Text = "帮助";
            // 
            // toolStripMenuItemDoc
            // 
            this.toolStripMenuItemDoc.Name = "toolStripMenuItemDoc";
            this.toolStripMenuItemDoc.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemDoc.Text = "使用说明";
            this.toolStripMenuItemDoc.Click += new System.EventHandler(this.toolStripMenuItemDoc_Click);
            // 
            // toolStripMenuItemSoftUpdate
            // 
            this.toolStripMenuItemSoftUpdate.Name = "toolStripMenuItemSoftUpdate";
            this.toolStripMenuItemSoftUpdate.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemSoftUpdate.Text = "检查更新";
            this.toolStripMenuItemSoftUpdate.Click += new System.EventHandler(this.toolStripMenuItemSoftUpdate_Click);
            // 
            // toolStripMenuItemAuthor
            // 
            this.toolStripMenuItemAuthor.Name = "toolStripMenuItemAuthor";
            this.toolStripMenuItemAuthor.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemAuthor.Text = "联系作者";
            this.toolStripMenuItemAuthor.Click += new System.EventHandler(this.toolStripMenuItemAuthor_Click);
            // 
            // toolStripMenuItemSetting
            // 
            this.toolStripMenuItemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.滚动速度ToolStripMenuItem});
            this.toolStripMenuItemSetting.Name = "toolStripMenuItemSetting";
            this.toolStripMenuItemSetting.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItemSetting.Text = "软件设置";
            // 
            // 滚动速度ToolStripMenuItem
            // 
            this.滚动速度ToolStripMenuItem.Name = "滚动速度ToolStripMenuItem";
            this.滚动速度ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.滚动速度ToolStripMenuItem.Text = "滚动速度";
            // 
            // FormPrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 578);
            this.Controls.Add(this.cmbPrize);
            this.Controls.Add(this.picEmp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.btnInitPool);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(883, 616);
            this.MinimumSize = new System.Drawing.Size(883, 616);
            this.Name = "FormPrize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "年会抽奖程序1.0";
            this.Load += new System.EventHandler(this.FormPrize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnInitPool;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.PictureBox picEmp;
        private System.Windows.Forms.ComboBox cmbPrize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDoc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSoftUpdate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAuthor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetting;
        private System.Windows.Forms.ToolStripMenuItem 滚动速度ToolStripMenuItem;
    }
}

