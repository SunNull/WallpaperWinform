using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;//添加引用，为了使用文件操作的相关方法(同时要通过菜单命令"项目-添加引用-Microsoft.VisualBasic")
using System.Runtime.InteropServices;//为了使用API
using Microsoft.Win32;//为了使用注册表的相关方法
using System.IO;
using CCWin;
using CCWin.SkinControl;
using System.Net;
using System.Xml.Linq;
using Wallpaper.DataEntity;
using Wallpaper.PleasantlySurprised;

namespace Wallpaper
{
    public partial class Form1 : CCSkinMain
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni); //该API可用于设置桌面墙纸

        //以下3个为SystemParametersInfo设置墙纸时用常量

        public const int SPI_SETDESKWALLPAPER = 20; //设置桌面墙纸

        public const int SPIF_UPDATEINIFILE = 1; //将新的参数写入用户Profile文件

        public const int SPIF_SENDWININICHANGE = 2;//广播WM_SETTINGCHANGE消息



        public int FileWidth;//图像文件的宽度

        public int FileHeight;//图像文件的高度

        public int CurrX;//显示在屏幕上的图像文件左上角的Ｘ坐标

        public int CurrY;//显示在屏幕上的图像文件左上角的Ｙ坐标

        public int HowLongChangeWallPaperDate=1;


        public int CurrentPictureFileIndex;//存放当前显示的图像文件的Index号

        public Boolean HaveShown;//当前墙纸的显示过程是否已经结束
        public List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            this.btnBrowse.Click += BtnBrowse_Click;
            this.btnApply.Click += BtnApply_Click;
            this.Load += Form1_Load1;
            this.timerChangeCurrentWallPaper.Tick += TimerChangeCurrentWallPaper_Tick;
            this.timerMoveWallPaper.Tick += TimerMoveWallPaper_Tick;
            this.btnStart.Click += BtnStart_Click;
            this.btnStop.Click += BtnStop_Click;
            this.btnManual.Click += BtnManual_Click;
            this.NotifyIcon.DoubleClick += NotifyIcon_DoubleClick;
            this.Deactivate += Form1_Deactivate;
            this.btnOpen.Click += BtnOpen_Click;
            this.btnclose.Click += Btnclose_Click;
            this.btnNext.Click += BtnNext_Click;
            this.tbxPassword.TextChanged += TbxPassword_TextChanged;
        }

        private void TbxPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxPassword.Text.Trim()))
                return;
            using(var context=new MyBookDB())
            {
                User user1 = new User();
                if(users.Count==0)
                {
                    users = context.User.ToList();
                    if(users.Count==0)
                    {
                        User user = new User();
                        user.IsMainAccount = true;
                        user.PassWord = "laolixiangni";
                        context.User.Add(user);
                        context.SaveChanges();
                        MessageBox.Show("这是密码：laolixiangni；不能让别人看到咯！");
                        New(user);
                    }
                }
                else
                {
                    var currentuser = users.FirstOrDefault(t => t.PassWord == tbxPassword.Text.Trim());
                    if (currentuser != null)
                        New(currentuser);
                }

            }
        }


        private void BtnNext_Click(object sender, EventArgs e)
        {
            ss();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process tt = System.Diagnostics.Process.GetProcessById(System.Diagnostics.Process.GetCurrentProcess().Id);
            //直接杀死与本程序相关的所有进程，有可能会导致数据丢失，但是不会抛出异常。 
            tt.Kill(); 
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Minimized)
            {
                this.NotifyIcon.Visible = true;
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void BtnManual_Click(object sender, EventArgs e)
        {
            ss();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timerChangeCurrentWallPaper.Enabled = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timerChangeCurrentWallPaper.Enabled = true;
        }


        private void BtnBrowse_Click(object sender, EventArgs e)//打开"浏览文件夹"对话框，将选定文件夹中的图片文件添加到列表框中
        {
            string TempStr;//临时变量：用于保存文件名
            Boolean BeenAdded;//临时变量:判断当前文件是否已经加入列表框中
            TempStr = "";
            FolderBrowserForPicture.ShowDialog();
            if (FolderBrowserForPicture.SelectedPath != "")//选择了文件夹
            {

                TempStr = FileSystem.Dir(FolderBrowserForPicture.SelectedPath + "\\*.*", Microsoft.VisualBasic.FileAttribute.Directory);

                while (TempStr != null)//该文件夹有文件
                {
                    var dd = TempStr.Substring(TempStr.LastIndexOf(".")).ToUpper();
                    if (((TempStr.Substring(TempStr.LastIndexOf(".")).ToUpper()) == ".BMP")
                        || ((TempStr.Substring(TempStr.LastIndexOf(".")).ToUpper()) == ".GIF")
                        || ((TempStr.Substring(TempStr.LastIndexOf(".")).ToUpper()) == ".JPG")
                        || ((TempStr.Substring(TempStr.LastIndexOf(".")).ToUpper()) == ".JPEG"))//如果为常见的图像文件
                    {

                        //下面判断该文件是否已经在列表框中

                        BeenAdded = false;

                        if (listBoxPictureFile.Items.Count >= 1)//列表框中有文件名
                        {
                            for (int j = 1; j <= listBoxPictureFile.Items.Count; j++)
                            {
                                if (listBoxPictureFile.Items[j - 1].ToString() == FolderBrowserForPicture.SelectedPath + @"\" + TempStr)
                                {
                                    BeenAdded = true;//已经在列表框中
                                    break;
                                }
                            }
                        }



                        if (!BeenAdded)//还没有加入列表框中
                        {
                            SkinListBoxItem item = new SkinListBoxItem(FolderBrowserForPicture.SelectedPath + @"\" + TempStr);
                            listBoxPictureFile.Items.Add(item);//将其加入列表框中
                        }
                    }
                    TempStr = Microsoft.VisualBasic.FileSystem.Dir();//继续查找下一个文件
                }

            }
        }
        private void dd()
        {
            string TempStr;//临时变量：用于保存文件名
            Boolean BeenAdded;//临时变量:判断当前文件是否已经加入列表框中
            TempStr = "";
            FolderBrowserForPicture.SelectedPath = @"D:\\桌面壁纸";
            if (FolderBrowserForPicture.SelectedPath != "")//选择了文件夹
            {

                TempStr = FileSystem.Dir(FolderBrowserForPicture.SelectedPath + "\\*.*", Microsoft.VisualBasic.FileAttribute.Directory);

                while (TempStr != null&&!string.IsNullOrWhiteSpace(TempStr))//该文件夹有文件
                {
                    var dd = TempStr.Substring(TempStr.LastIndexOf(".")).ToUpper();
                    if (((TempStr.Substring(TempStr.LastIndexOf(".")).ToUpper()) == ".BMP")
                        || ((TempStr.Substring(TempStr.LastIndexOf(".")).ToUpper()) == ".GIF")
                        || ((TempStr.Substring(TempStr.LastIndexOf(".")).ToUpper()) == ".JPG")
                        || ((TempStr.Substring(TempStr.LastIndexOf(".")).ToUpper()) == ".JPEG"))//如果为常见的图像文件
                    {
                        //下面判断该文件是否已经在列表框中
                        BeenAdded = false;
                        
                        if (listBoxPictureFile.Items.Count >= 1)//列表框中有文件名
                        {
                            for (int j = 1; j <= listBoxPictureFile.Items.Count; j++)
                            {
                                if (listBoxPictureFile.Items[j - 1].ToString() == FolderBrowserForPicture.SelectedPath + @"\" + TempStr)
                                {
                                    BeenAdded = true;//已经在列表框中
                                    break;
                                }
                            }
                        }
                        if (!BeenAdded)//还没有加入列表框中
                        {
                            SkinListBoxItem item = new SkinListBoxItem(FolderBrowserForPicture.SelectedPath + @"\" + TempStr);
                            listBoxPictureFile.Items.Add(item);//将其加入列表框中
                        }
                    }
                    TempStr = Microsoft.VisualBasic.FileSystem.Dir();//继续查找下一个文件
                }

            }
        }
        private void Form1_Load1(object sender, EventArgs e)//程序启动时设置墙纸的显示方式为“居中”
        {
            SetAutoStart();
            IsEist();
            //通过修改注册表实现
            RegistryKey TRegKey;
            TRegKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            if (TRegKey != null)
            {
                TRegKey.SetValue("WallpaperStyle", "0");
                TRegKey.SetValue("TileWallpaper", "0");
            }
            timerChangeCurrentWallPaper.Interval = (int)HowLongChangeWallPaper.Value * 1000 * 60;

            timerChangeCurrentWallPaper.Enabled = true;

            CurrentPictureFileIndex = 0;

            HaveShown = true;
            dd();
        }
        private void TimerChangeCurrentWallPaper_Tick(object sender, EventArgs e)//定时改变当前的墙纸文件
        {
            //设置列表框中下一个文件为当前的桌面墙纸文件
            ss();

        }
        private void ss()
        {
            if (listBoxPictureFile.Items.Count > 0 && HaveShown)
            {
                if (CurrentPictureFileIndex < listBoxPictureFile.Items.Count - 1)
                {
                    CurrentPictureFileIndex += 1;
                }
                else
                {
                    CurrentPictureFileIndex = 0;
                }
                HaveShown = false;
                Bitmap tBmp1 = new Bitmap(listBoxPictureFile.Items[CurrentPictureFileIndex].ToString());//根据选择的图像文件建立一个bitmap对象

                FileWidth = tBmp1.Width; //获得图片文件的宽度和高度

                FileHeight = tBmp1.Height;

                //if (tBmp1.Width <= Screen.PrimaryScreen.Bounds.Width & tBmp1.Height <= Screen.PrimaryScreen.Bounds.Height)
                //{//图片的宽度和高度都小于桌面时，则直接显示

                SetWallPaper(listBoxPictureFile.Items[CurrentPictureFileIndex].ToString(), 0, 0, tBmp1.Width, tBmp1.Height);

                HaveShown = true;

                //}//否则，启动定时器并进行动态显示
                //else
                //{
                //    CurrX = 0; //从图片的左上角开始

                //    CurrY = 0;
                //    timerMoveWallPaper.Enabled = true;//启动定时器

                //}
                tBmp1.Dispose();
            }
        }
        private void TimerMoveWallPaper_Tick(object sender, EventArgs e)//定时移动当前的墙纸文件
        {
            Boolean CanMoveLeft; //图片是否可以左移

            Boolean CanmoveUp; //是否可以上移

            if (FileWidth - CurrX >= Screen.PrimaryScreen.Bounds.Width)
            {
                //可以左移图片
                CanMoveLeft = true;

                CurrX += Math.Min(12, FileWidth - CurrX); //每次横向向左最多移动12像素
            }
            else
            {
                CanMoveLeft = false;
            }
            if (FileHeight - CurrY >= Screen.PrimaryScreen.Bounds.Height)
            {
                //可以上移图片
                CanmoveUp = true;

                CurrY += Math.Min(9, FileHeight - CurrY); //每次纵向向上最多移动9像素
            }
            else
            {
                CanmoveUp = false;
            }

            if (CanMoveLeft == false & CanmoveUp == false)//图片已不能上移和左移
            {
                timerMoveWallPaper.Enabled = false;//停止定时器
                HaveShown = true;
            }

            int DisplayPicWidth;//屏幕上显示的图片区域的宽度和高度

            int DisplayPicHeight;

            if (CurrX + Screen.PrimaryScreen.Bounds.Width <= FileWidth)
            {
                DisplayPicWidth = Screen.PrimaryScreen.Bounds.Width;
            }
            else
            {
                DisplayPicWidth = FileWidth - CurrX;
            }

            if (CurrY + Screen.PrimaryScreen.Bounds.Height <= FileHeight)
            {
                DisplayPicHeight = Screen.PrimaryScreen.Bounds.Height;
            }
            else
            {
                DisplayPicHeight = FileHeight - CurrY;
            }
            SetWallPaper(listBoxPictureFile.Items[CurrentPictureFileIndex].ToString(), CurrX, CurrY, DisplayPicWidth, DisplayPicHeight);//调用设置墙纸过程
        }

        //本段程序的基本原理：使用Bitmap类的Clone和Save方法将图片的指定区域保存为临时文件，再使用SystemParametersInfo将临时文件设置为桌面墙纸。
        private void SetWallPaper(string SelectedPicFile, int CurrX, int CurrY, int PicWidth, int PicHeight)
        {//将图片文件的指定区域保存为ＢＭＰ文件，并设置为墙纸文件

            Bitmap tBmp1 = new Bitmap(SelectedPicFile);//根据选择的图像文件建立一个Bitmap对象

            System.Drawing.Imaging.PixelFormat format = tBmp1.PixelFormat;

            Rectangle cloneRect = new Rectangle(CurrX, CurrY, PicWidth, PicHeight);

            Bitmap cloneBitmap = tBmp1.Clone(cloneRect, format);//根据源图片文件和指定区域，建立bitmap对象

            cloneBitmap.Save(@"D:\\Temp.bmp", System.Drawing.Imaging.ImageFormat.Bmp);//将bitmap对象保存为BMP文件，因为程序中只能使用BMP图像

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, @"D:\\Temp.bmp", SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);//设置为墙纸

            tBmp1.Dispose();
        }



        private void BtnApply_Click(object sender, EventArgs e)//应用当前的设置
        {
            timerChangeCurrentWallPaper.Interval = (int)HowLongChangeWallPaper.Value * 1000 * 60;

            timerChangeCurrentWallPaper.Enabled = true;

        }
        private void SetAutoStart()
        {
            try
            {
                //var ip =Page.Request.UserHostAddress();
                //string regPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";//注册表
                string regPath = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";//注册表
                string path = Application.ExecutablePath.ToLower(); //获取.exe当前程序路径
                //MessageBox.Show(path);
                string name = Path.GetFileName(path);  //获得应用程序名称
                //MessageBox.Show(name);
                var regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(regPath, true);
                //MessageBox.Show(regKey.ToString());
                if (regKey == null)
                    regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(regPath);
                regKey.SetValue(name, path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        /// <summary>
        /// 判断当前文件是否存在，不存在需要手动创建
        /// </summary>
        private void IsEist()
        {
            if (!(File.Exists(@"D:\Temp.bmp")) && !(Directory.Exists(@"D:\\桌面壁纸")))
            {
                File.Create(@"D:\\Temp.bmp");
                Directory.CreateDirectory(@"D:\\桌面壁纸");
            }
            else if (!(File.Exists(@"D:\Temp.bmp")))
                File.Create(@"D:\\Temp.bmp");
            else if(!Directory.Exists(@"D:\\桌面壁纸"))
                Directory.CreateDirectory(@"D:\\桌面壁纸");
        }

        public void New(User user)
        {
            this.tbxPassword.Text = string.Empty;
            this.NotifyIcon.Visible = true;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            UC_PleasantlySurprised uc = new UC_PleasantlySurprised();
            uc.user = user;
            uc.ShowDialog();
            uc.Dispose();
        }
    }
}
