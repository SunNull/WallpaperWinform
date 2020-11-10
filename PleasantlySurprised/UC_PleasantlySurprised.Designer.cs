namespace Wallpaper.PleasantlySurprised
{
    partial class UC_PleasantlySurprised
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PleasantlySurprised));
            this.riqi = new CCWin.SkinControl.SkinLabel();
            this.dtpStarDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.dtiEndDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.btnSearch = new CCWin.SkinControl.SkinButton();
            this.dgvContent = new CCWin.SkinControl.SkinDataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaryContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinMenuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdatePassword = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryContentBindingSource)).BeginInit();
            this.skinMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // riqi
            // 
            this.riqi.AutoSize = true;
            this.riqi.BackColor = System.Drawing.Color.Transparent;
            this.riqi.BorderColor = System.Drawing.Color.White;
            this.riqi.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.riqi.Location = new System.Drawing.Point(22, 66);
            this.riqi.Name = "riqi";
            this.riqi.Size = new System.Drawing.Size(44, 17);
            this.riqi.TabIndex = 0;
            this.riqi.Text = "日期段";
            // 
            // dtpStarDate
            // 
            this.dtpStarDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpStarDate.DropDownHeight = 180;
            this.dtpStarDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtpStarDate.DropDownWidth = 120;
            this.dtpStarDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtpStarDate.Items = null;
            this.dtpStarDate.Location = new System.Drawing.Point(72, 61);
            this.dtpStarDate.Name = "dtpStarDate";
            this.dtpStarDate.Size = new System.Drawing.Size(114, 22);
            this.dtpStarDate.TabIndex = 1;
            this.dtpStarDate.text = "";
            // 
            // dtiEndDate
            // 
            this.dtiEndDate.BackColor = System.Drawing.Color.Transparent;
            this.dtiEndDate.DropDownHeight = 180;
            this.dtiEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtiEndDate.DropDownWidth = 120;
            this.dtiEndDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtiEndDate.Items = null;
            this.dtiEndDate.Location = new System.Drawing.Point(226, 61);
            this.dtiEndDate.Name = "dtiEndDate";
            this.dtiEndDate.Size = new System.Drawing.Size(114, 22);
            this.dtiEndDate.TabIndex = 1;
            this.dtiEndDate.text = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(192, 64);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(28, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "----";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSearch.DownBack = null;
            this.btnSearch.Location = new System.Drawing.Point(379, 62);
            this.btnSearch.MouseBack = null;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormlBack = null;
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvContent
            // 
            this.dgvContent.AllowUserToAddRows = false;
            this.dgvContent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvContent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContent.AutoGenerateColumns = false;
            this.dgvContent.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvContent.ColumnFont = null;
            this.dgvContent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clCreateDate,
            this.clWather,
            this.clContent,
            this.clUserID});
            this.dgvContent.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvContent.DataSource = this.diaryContentBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContent.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContent.EnableHeadersVisualStyles = false;
            this.dgvContent.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvContent.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvContent.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvContent.Location = new System.Drawing.Point(25, 91);
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.ReadOnly = true;
            this.dgvContent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvContent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvContent.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvContent.RowTemplate.Height = 23;
            this.dgvContent.Size = new System.Drawing.Size(429, 291);
            this.dgvContent.TabIndex = 3;
            this.dgvContent.TitleBack = null;
            this.dgvContent.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvContent.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "ID";
            this.clID.Name = "clID";
            this.clID.ReadOnly = true;
            this.clID.Visible = false;
            // 
            // clCreateDate
            // 
            this.clCreateDate.DataPropertyName = "CreateDate";
            dataGridViewCellStyle3.Format = "yyyy-MM-dd HH:mm";
            this.clCreateDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.clCreateDate.HeaderText = "日期";
            this.clCreateDate.Name = "clCreateDate";
            this.clCreateDate.ReadOnly = true;
            this.clCreateDate.Width = 120;
            // 
            // clWather
            // 
            this.clWather.DataPropertyName = "Wather";
            this.clWather.HeaderText = "天气";
            this.clWather.Name = "clWather";
            this.clWather.ReadOnly = true;
            this.clWather.Width = 80;
            // 
            // clContent
            // 
            this.clContent.DataPropertyName = "Content";
            this.clContent.HeaderText = "日记";
            this.clContent.Name = "clContent";
            this.clContent.ReadOnly = true;
            this.clContent.Width = 185;
            // 
            // clUserID
            // 
            this.clUserID.DataPropertyName = "UserID";
            this.clUserID.HeaderText = "UserID";
            this.clUserID.Name = "clUserID";
            this.clUserID.ReadOnly = true;
            this.clUserID.Visible = false;
            // 
            // diaryContentBindingSource
            // 
            this.diaryContentBindingSource.DataSource = typeof(Wallpaper.DataEntity.DiaryContent);
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip1.Back = System.Drawing.Color.White;
            this.skinMenuStrip1.BackRadius = 4;
            this.skinMenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinMenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.BaseForeAnamorphosis = false;
            this.skinMenuStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseItemAnamorphosis = true;
            this.skinMenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemBorderShow = true;
            this.skinMenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemDown")));
            this.skinMenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemMouse")));
            this.skinMenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemRadius = 4;
            this.skinMenuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.ItemAnamorphosis = true;
            this.skinMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemBorderShow = true;
            this.skinMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemRadius = 4;
            this.skinMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnUpdate,
            this.btnDelete,
            this.btnUpdatePassword});
            this.skinMenuStrip1.Location = new System.Drawing.Point(4, 28);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Size = new System.Drawing.Size(475, 24);
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TabIndex = 4;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Wallpaper.Properties.Resources.新建;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(28, 20);
            this.btnNew.ToolTipText = "新建";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::Wallpaper.Properties.Resources.编辑;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(28, 20);
            this.btnUpdate.ToolTipText = "修改日记";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Wallpaper.Properties.Resources.删_除;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(28, 20);
            this.btnDelete.ToolTipText = "删除日记";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Image = global::Wallpaper.Properties.Resources.密码修改;
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(28, 20);
            // 
            // UC_PleasantlySurprised
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 399);
            this.Controls.Add(this.dgvContent);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtiEndDate);
            this.Controls.Add(this.dtpStarDate);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.riqi);
            this.Controls.Add(this.skinMenuStrip1);
            this.MainMenuStrip = this.skinMenuStrip1;
            this.Name = "UC_PleasantlySurprised";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "惊喜界面";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryContentBindingSource)).EndInit();
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel riqi;
        private CCWin.SkinControl.SkinDateTimePicker dtpStarDate;
        private CCWin.SkinControl.SkinDateTimePicker dtiEndDate;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton btnSearch;
        private CCWin.SkinControl.SkinDataGridView dgvContent;
        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.BindingSource diaryContentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWather;
        private System.Windows.Forms.DataGridViewTextBoxColumn clContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserID;
        private System.Windows.Forms.ToolStripMenuItem btnUpdatePassword;
    }
}