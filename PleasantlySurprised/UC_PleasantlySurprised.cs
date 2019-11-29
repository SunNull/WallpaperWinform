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
    public partial class UC_PleasantlySurprised : CCSkinMain
    {
        public List<DiaryContent> list = new List<DiaryContent>();
        public DiaryContent diaryContent = new DiaryContent();
        public User user = new User();
        public UC_PleasantlySurprised()
        {
            InitializeComponent();
            this.Load += UC_PleasantlySurprised_Load;
            this.btnSearch.Click += BtnSearch_Click;
            this.btnNew.Click += BtnNew_Click;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.btnDelete.Click += BtnDelete_Click;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvContent.SelectedRows.Count == 0)
                return;
            if(this.dgvContent.CurrentRow.Cells["clID"].Value != null)
            {
                var id = int.Parse(this.dgvContent.CurrentRow.Cells["clID"].Value.ToString());
                using(var context=new MyBookDB())
                {
                    var currentcontent = context.DiaryContent.FirstOrDefault(t => t.ID == id);
                    if (currentcontent == null)
                        return;
                    context.DiaryContent.Remove(currentcontent);
                    context.SaveChanges();
                    //this.dgvContent.Rows.Remove(this.dgvContent.CurrentRow);
                    MessageBox.Show("已经删除啦！");
                }
            }
            Search();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvContent.SelectedRows.Count == 0)
                return;
            var id = int.Parse(this.dgvContent.CurrentRow.Cells["clID"].Value.ToString());
            using(var context=new MyBookDB())
            {
                var currentcontent = context.DiaryContent.FirstOrDefault(t => t.ID == id);
                if(currentcontent==null)
                {
                    UI_DiaryContent ui = new UI_DiaryContent();
                    ui.user = user;
                    ui.IsNew = true;
                    ui.ShowDialog();
                    ui.Dispose();
                }
                else
                {
                    UI_DiaryContent ui = new UI_DiaryContent();
                    ui.user = user;
                    ui.IsNew = false;
                    ui.DiaryContent = currentcontent;
                    ui.ShowDialog();
                    ui.Dispose();
                }
            }
            Search();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            UI_DiaryContent ui = new UI_DiaryContent();
            ui.user = user;
            ui.IsNew = true;
            ui.ShowDialog();
            ui.Dispose();
            Search();
        }

        private void UC_PleasantlySurprised_Load(object sender, EventArgs e)
        {
            Search();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            using (var context = new MyBookDB())
            {
                list = context.DiaryContent.Where(t => t.UserID == user.ID).ToList();
                this.dgvContent.DataSource = list;
            }
        }
    }
}
