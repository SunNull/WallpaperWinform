namespace Wallpaper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HowLongChangeWallPaper = new System.Windows.Forms.NumericUpDown();
            this.FolderBrowserForPicture = new System.Windows.Forms.FolderBrowserDialog();
            this.timerChangeCurrentWallPaper = new System.Windows.Forms.Timer(this.components);
            this.timerMoveWallPaper = new System.Windows.Forms.Timer(this.components);
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNext = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnclose = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.btnBrowse = new CCWin.SkinControl.SkinButton();
            this.btnApply = new CCWin.SkinControl.SkinButton();
            this.btnStop = new CCWin.SkinControl.SkinButton();
            this.btnStart = new CCWin.SkinControl.SkinButton();
            this.btnManual = new CCWin.SkinControl.SkinButton();
            this.listBoxPictureFile = new CCWin.SkinControl.SkinListBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnSetting = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.HowLongChangeWallPaper)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HowLongChangeWallPaper
            // 
            this.HowLongChangeWallPaper.Location = new System.Drawing.Point(217, 29);
            this.HowLongChangeWallPaper.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.HowLongChangeWallPaper.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HowLongChangeWallPaper.Name = "HowLongChangeWallPaper";
            this.HowLongChangeWallPaper.Size = new System.Drawing.Size(70, 21);
            this.HowLongChangeWallPaper.TabIndex = 1;
            this.HowLongChangeWallPaper.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timerMoveWallPaper
            // 
            this.timerMoveWallPaper.Interval = 1000;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "老李壁纸";
            this.NotifyIcon.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNext,
            this.btnOpen,
            this.btnclose});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // btnNext
            // 
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 22);
            this.btnNext.Text = "下一张";
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(124, 22);
            this.btnOpen.Text = "打开界面";
            // 
            // btnclose
            // 
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(124, 22);
            this.btnclose.Text = "退出";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(19, 28);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(176, 17);
            this.skinLabel1.TabIndex = 4;
            this.skinLabel1.Text = "更换桌面壁纸时间间隔（分钟）";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnBrowse.DownBack = null;
            this.btnBrowse.Location = new System.Drawing.Point(22, 55);
            this.btnBrowse.MouseBack = null;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.NormlBack = null;
            this.btnBrowse.Size = new System.Drawing.Size(86, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "添加图片文件";
            this.btnBrowse.UseVisualStyleBackColor = false;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnApply.DownBack = null;
            this.btnApply.Location = new System.Drawing.Point(114, 55);
            this.btnApply.MouseBack = null;
            this.btnApply.Name = "btnApply";
            this.btnApply.NormlBack = null;
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "应用当前修改";
            this.btnApply.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStop.DownBack = null;
            this.btnStop.Location = new System.Drawing.Point(195, 55);
            this.btnStop.MouseBack = null;
            this.btnStop.Name = "btnStop";
            this.btnStop.NormlBack = null;
            this.btnStop.Size = new System.Drawing.Size(43, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStart.DownBack = null;
            this.btnStart.Location = new System.Drawing.Point(244, 56);
            this.btnStart.MouseBack = null;
            this.btnStart.Name = "btnStart";
            this.btnStart.NormlBack = null;
            this.btnStart.Size = new System.Drawing.Size(43, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.Transparent;
            this.btnManual.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnManual.DownBack = null;
            this.btnManual.Location = new System.Drawing.Point(293, 56);
            this.btnManual.MouseBack = null;
            this.btnManual.Name = "btnManual";
            this.btnManual.NormlBack = null;
            this.btnManual.Size = new System.Drawing.Size(43, 23);
            this.btnManual.TabIndex = 5;
            this.btnManual.Text = "手动";
            this.btnManual.UseVisualStyleBackColor = false;
            // 
            // listBoxPictureFile
            // 
            this.listBoxPictureFile.Back = null;
            this.listBoxPictureFile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxPictureFile.FormattingEnabled = true;
            this.listBoxPictureFile.Location = new System.Drawing.Point(22, 85);
            this.listBoxPictureFile.Name = "listBoxPictureFile";
            this.listBoxPictureFile.Size = new System.Drawing.Size(314, 82);
            this.listBoxPictureFile.TabIndex = 6;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(322, 197);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(25, 14);
            this.skinLabel2.TabIndex = 7;
            this.skinLabel2.Text = "V1.0";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(22, 173);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(314, 21);
            this.tbxPassword.TabIndex = 8;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSetting.DownBack = null;
            this.btnSetting.Location = new System.Drawing.Point(293, 29);
            this.btnSetting.MouseBack = null;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.NormlBack = null;
            this.btnSetting.Size = new System.Drawing.Size(43, 23);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "设定";
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 215);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.listBoxPictureFile);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.HowLongChangeWallPaper);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "老李壁纸自动更换";
            ((System.ComponentModel.ISupportInitialize)(this.HowLongChangeWallPaper)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown HowLongChangeWallPaper;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserForPicture;
        private System.Windows.Forms.Timer timerChangeCurrentWallPaper;
        private System.Windows.Forms.Timer timerMoveWallPaper;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnclose;
        private System.Windows.Forms.ToolStripMenuItem btnNext;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton btnBrowse;
        private CCWin.SkinControl.SkinButton btnApply;
        private CCWin.SkinControl.SkinButton btnStop;
        private CCWin.SkinControl.SkinButton btnStart;
        private CCWin.SkinControl.SkinButton btnManual;
        private CCWin.SkinControl.SkinListBox listBoxPictureFile;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.TextBox tbxPassword;
        private CCWin.SkinControl.SkinButton btnSetting;
    }
}

