using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wallpaper.DataEntity;

namespace Wallpaper.PleasantlySurprised
{
    public partial class UI_DiaryContent : CCSkinMain
    {
        public User user = new User();
        public DiaryContent DiaryContent = new DiaryContent();
        public bool IsNew;
        public UI_DiaryContent()
        {
            InitializeComponent();
            this.Load += UI_DiaryContent_Load;
            this.btnCancel.Click += BtnCancel_Click;
            this.btnSave.Click += BtnSave_Click;
        }

        private void UI_DiaryContent_Load(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                this.tbxWather.Text = DiaryContent.Wather;
                this.tbxContent.Text = DiaryContent.Content;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbxContent.Text.Trim()))
            {
                MessageBox.Show("日记还没写，不能保存的啊！");
                return;
            }
            if(IsNew)
            {
                DiaryContent.Content = tbxContent.Text;
                DiaryContent.CreateDate = DateTime.Now;
                DiaryContent.Wather = tbxWather.Text.Trim();
                DiaryContent.UserID = user.ID;
                using(var context=new MyBookDB())
                {
                    context.DiaryContent.Add(DiaryContent);
                    context.SaveChanges();
                }
            }
            else
            {
                DiaryContent.Content = tbxContent.Text;
                DiaryContent.Wather = tbxWather.Text.Trim();
                using (var context = new MyBookDB())
                {
                    var old = context.DiaryContent.FirstOrDefault(t => t.ID == DiaryContent.ID);
                    if(old==null)
                    {
                        context.DiaryContent.Add(DiaryContent);
                        context.SaveChanges();
                    }
                    else
                    {
                        context.DiaryContent.Remove(old);
                        context.DiaryContent.Add(DiaryContent);
                        context.SaveChanges();
                    }
                }
            }
            MessageBox.Show("保存成功咯！");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
