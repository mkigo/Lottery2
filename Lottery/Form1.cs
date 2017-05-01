using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

///抽奖小程序,这次做一个滚动图片版本的，这个更简单
///魏韶颖
///2016年1月4日
///由于每个人一个图片文件并以名字命名，操作系统不允许重名，所以这里去掉了重名检查
///且只有一个图片没有上下滚动，去掉了反向滚动功能
///
namespace Lottery
{
    public partial class FormPrize : Form
    {
        //默认显示第一个人的照片
        private int p1 = 0;

        private List<Image> pictureList = new List<Image>();

        private List<string> nameList = new List<string>();

        string _ImagePath = Path.Combine(Application.StartupPath, "Images");

        private string titleSoftName = "公司年会抽奖程序";
        private string titleWait = "正在抽奖,请点击停止";

        private static string _TipHelp = "请将员工的照片放到Images文件夹中，大小为128x128像素\n格式为jpg、png或bmp，并以员工姓名命名，如：张三.jpg";
        private static string _TipError = "初始化奖池失败，" + _TipHelp;
        private string _TipOnlyOne = "只有一张有效照片，抽奖没有意义";

        private bool bError;

        public FormPrize()
        {
            InitializeComponent();
        }

        private void FormPrize_Load(object sender, EventArgs e)
        {
            this.lblWait.Text = titleSoftName;
            this.lblEmpName.Text = null;

            this.timer1.Interval = 110;//中间值
            this.cmbPrize.SelectedIndex = 1;
            InitData();
        }

        private void InitData()
        {
            LoadFromFile();
            if (bError)
            {
                this.btnStart.Enabled = false;
                return;
            }
        }

        //定义规则：把员工128*128大小的照片，并以名字命名放到Images下
        private void LoadFromFile()
        {
            //简单点，没有做递归查找图片
            pictureList.Clear();
            nameList.Clear();
            try
            {
                DirectoryInfo folder = new DirectoryInfo(_ImagePath);

                FileInfo[] fiArr1 = folder.GetFiles("*.jpg");
                InitArrs(fiArr1);

                FileInfo[] fiArr2 = folder.GetFiles("*.png");
                InitArrs(fiArr2);

                FileInfo[] fiArr3 = folder.GetFiles("*.bmp");
                InitArrs(fiArr3);

                if (null == nameList || nameList.Count < 1)
                {
                    bError = true;
                    MessageBox.Show(_TipError);
                    return;
                }
                if (nameList.Count == 1)
                {
                    bError = true;
                    MessageBox.Show(_TipOnlyOne);
                    return;
                }

                //初始化成功后默认显示第一个
                this.picEmp.Image = this.pictureList[p1];
                this.lblEmpName.Text = this.nameList[p1];
            }
            catch (Exception)
            {
                bError = true;
                MessageBox.Show(_TipError);
                return;
            }
        }

        private void InitArrs(FileInfo[] fiArr1)
        {
            if (null != fiArr1 && fiArr1.Length > 0)
            {
                foreach (FileInfo file in fiArr1)
                {
                    nameList.Add(file.Name.Substring(0, file.Name.IndexOf('.')));
                    pictureList.Add(Image.FromFile(file.FullName));
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            p1++;
            if (p1 >= pictureList.Count)
            {
                p1 = 0;
            }
            this.picEmp.Image = pictureList[p1];
            this.lblEmpName.Text = nameList[p1];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (bError)
            {
                return;
            }
            this.timer1.Start();
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
            this.lblResult.Text = null;
            this.lblResult.Hide();
            this.lblWait.Text = titleWait;
            this.lblWait.Show();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
            string result = string.Format("恭喜 {0} 获得{1}！", this.lblEmpName.Text, this.cmbPrize.SelectedItem.ToString());
            this.lblResult.Text = result;
            this.lblResult.Show();
            this.lblWait.Hide();
        }

        private void btnInitPool_Click(object sender, EventArgs e)
        {
            LoadFromFile();
            MessageBox.Show("初始化奖池完成，共" + nameList.Count + "人");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //频率：10ms - 210ms
            this.timer1.Interval = 210 - this.trackBar1.Value * 20;
        }

        private void toolStripMenuItemAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("微信号：weishaoying\n编写日期：2016年1月4日");
        }

        private void toolStripMenuItemDoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_TipHelp);
        }

        private void toolStripMenuItemSoftUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已是最新版本");
        }


    }
}
