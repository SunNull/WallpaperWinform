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
    public partial class UI_UpdatePassword : CCSkinMain
    {
        public User user;
        public UI_UpdatePassword()
        {
            InitializeComponent();
            this.Load += UI_UpdatePassword_Load;
            this.btnOK.Click += BtnOK_Click;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            using (var context = new MyBookDB())
            {
                if(tbxNewPassword.Text==tbxOldPassword.Text)
                {
                    MessageBox.Show("新旧密码相同，不需要修改啦！");
                }
                var currentuserOld = context.User.FirstOrDefault(t => t.ID == user.ID);
                User newuser = new User();
                newuser.PassWord = tbxNewPassword.Text;
                newuser.IsMainAccount = currentuserOld.IsMainAccount;
                context.User.Remove(currentuserOld);
                context.User.Add(newuser);
                context.SaveChanges();
                MessageBox.Show("修改好咯！");
                this.Close();
            }
        }

        private void UI_UpdatePassword_Load(object sender, EventArgs e)
        {
            this.tbxOldPassword.Text = user.PassWord;
        }
    }
}
