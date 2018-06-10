using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 年会抽奖
{
    public partial class MainForm : Form
    {
        List<string> GlobalNameList = new List<string>();


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化界面
            BackgroundImage = Image.FromFile(BgScreen.GetBgImg());

            labelTitle.Text = "XX公司年会抽奖活动";
            labelPrizeLevel.Text = "";
            labelPrizeName.Text = "年年有乐！";

            pictureBox1.BackgroundImage = Resource1.picNone;
            pictureBox1.Image = Resource1.picNone;

            buttonBeginStop.Text = "开始";
            buttonNextPage.Text = "抽奖";

            labelName1.Text = "";
            labelName2.Text = "";
            labelName3.Text = "";
            labelName4.Text = "";
            labelName5.Text = "";
            labelName6.Text = "";
            labelName7.Text = "";
            labelName8.Text = "";
            labelName9.Text = "";
            labelName10.Text = "";

            labelNameBig.Text = "";

            buttonBeginStop.Visible = false;


            //初始化随机种子
            SeedRand.Init();

            // sample抽奖活动 初始化
            SampleLottery.Init();
            labelTitle.Text = SampleLottery.DrawTitleString;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            GlobalNameList = SampleLottery.getWinner();

            switch (GlobalNameList.Count)
            {
                case 1:
                    labelNameBig.Visible = true;
                    labelNameBig.Text = GlobalNameList[0];
                    break;
                case 2:
                    labelName4.Visible = true;
                    labelName6.Visible = true;
                    labelName4.Text = GlobalNameList[0];
                    labelName6.Text = GlobalNameList[1];
                    break;
                case 5:
                    labelName1.Visible = true;
                    labelName3.Visible = true;
                    labelName5.Visible = true;
                    labelName7.Visible = true;
                    labelName9.Visible = true;

                    labelName1.Text = GlobalNameList[0];
                    labelName3.Text = GlobalNameList[1];
                    labelName5.Text = GlobalNameList[2];
                    labelName7.Text = GlobalNameList[3];
                    labelName9.Text = GlobalNameList[4];
                    break;
                case 10:
                    labelName1.Visible = true;
                    labelName2.Visible = true;
                    labelName3.Visible = true;
                    labelName4.Visible = true;
                    labelName5.Visible = true;
                    labelName6.Visible = true;
                    labelName7.Visible = true;
                    labelName8.Visible = true;
                    labelName9.Visible = true;
                    labelName10.Visible = true;

                    labelName1.Text = GlobalNameList[0];
                    labelName2.Text = GlobalNameList[1];
                    labelName3.Text = GlobalNameList[2];
                    labelName4.Text = GlobalNameList[3];
                    labelName5.Text = GlobalNameList[4];
                    labelName6.Text = GlobalNameList[5];
                    labelName7.Text = GlobalNameList[6];
                    labelName8.Text = GlobalNameList[7];
                    labelName9.Text = GlobalNameList[8];
                    labelName10.Text = GlobalNameList[9];
                    break;
                case 3:
                case 4:
                case 6:
                case 7:
                case 8:
                case 9:
                    try
                    {
                        labelName1.Visible = true;
                        labelName2.Visible = true;
                        labelName3.Visible = true;
                        labelName4.Visible = true;
                        labelName5.Visible = true;
                        labelName6.Visible = true;
                        labelName7.Visible = true;
                        labelName8.Visible = true;
                        labelName9.Visible = true;
                        labelName10.Visible = true;

                        labelName1.Text = GlobalNameList[0];
                        labelName2.Text = GlobalNameList[1];
                        labelName3.Text = GlobalNameList[2];
                        labelName4.Text = GlobalNameList[3];
                        labelName5.Text = GlobalNameList[4];
                        labelName6.Text = GlobalNameList[5];
                        labelName7.Text = GlobalNameList[6];
                        labelName8.Text = GlobalNameList[7];
                        labelName9.Text = GlobalNameList[8];
                        labelName10.Text = GlobalNameList[9];
                    }
                    catch
                    {
                        //不处理
                    }
                    break;
                

                default:
                    try
                    {
                        labelName1.Visible = true;
                        labelName2.Visible = true;
                        labelName3.Visible = true;
                        labelName4.Visible = true;
                        labelName5.Visible = true;
                        labelName6.Visible = true;
                        labelName7.Visible = true;
                        labelName8.Visible = true;
                        labelName9.Visible = true;
                        labelName10.Visible = true;

                        labelName1.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        labelName2.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        labelName3.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        labelName4.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        labelName5.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        labelName6.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        labelName7.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        labelName8.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        labelName9.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        labelName10.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));


                        labelName1.Text = GlobalNameList[0] + "   " + GlobalNameList[1];
                        labelName2.Text = GlobalNameList[2] + "   " + GlobalNameList[3];
                        labelName3.Text = GlobalNameList[4] + "   " + GlobalNameList[5];
                        labelName4.Text = GlobalNameList[6] + "   " + GlobalNameList[7];
                        labelName5.Text = GlobalNameList[8] + "   " + GlobalNameList[9];
                        labelName6.Text = GlobalNameList[10] + "   " + GlobalNameList[11];
                        labelName7.Text = GlobalNameList[12] + "   " + GlobalNameList[13];
                        labelName8.Text = GlobalNameList[14] + "   " + GlobalNameList[15];
                        labelName9.Text = GlobalNameList[16] + "   " + GlobalNameList[17];
                        labelName10.Text = GlobalNameList[18] + "   " + GlobalNameList[19];
                    }
                    catch
                    {
                        //不处理
                    }

                    break;
            }
        }
        

        private void clearNameList()
        {
            labelNameBig.Text = "";
            labelName1.Text = "";
            labelName2.Text = "";
            labelName3.Text = "";
            labelName4.Text = "";
            labelName5.Text = "";
            labelName6.Text = "";
            labelName7.Text = "";
            labelName8.Text = "";
            labelName9.Text = "";
            labelName10.Text = "";

            labelNameBig.Visible = false;
            labelName1.Visible = false;
            labelName2.Visible = false;
            labelName3.Visible = false;
            labelName4.Visible = false;
            labelName5.Visible = false;
            labelName6.Visible = false;
            labelName7.Visible = false;
            labelName8.Visible = false;
            labelName9.Visible = false;
            labelName10.Visible = false;

            labelName1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            labelName2.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            labelName3.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            labelName4.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            labelName5.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            labelName6.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            labelName7.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            labelName8.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            labelName9.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            labelName10.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            
        }

        private void btnBegin()
        {
            //清空名单
            clearNameList();

            //启动定时器
            timer1.Enabled = true;
        }

        private void btnStop()
        {
            timer1.Enabled = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(buttonBeginStop.Text == "开始")
            {
                buttonBeginStop.Text = "停止";
                //启动定时器开始抽奖
                btnBegin();

            }
            else if (buttonBeginStop.Text == "停止")
            {
                buttonBeginStop.Text = "开始";
                btnStop();
            }

        }


        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            //--状态列表--
            //进入抽奖
            //
            //下一项
            //
            //

            if (buttonNextPage.Text == "抽奖")
            {
                buttonNextPage.Text = "下一项";
                buttonBeginStop.Visible = true;

                //刷新页面内容
                clearNameList();
                labelPrizeName.Text = SampleLottery.getNowPrizeName();
                pictureBox1.Image = SampleLottery.getNowImage();
            }
            else if (buttonNextPage.Text == "下一项")
            {
                //先执行stop
                buttonBeginStop.Text = "开始";
                btnStop();

                //添加到结果中
                SampleLottery.addPrizeResult(GlobalNameList);
                GlobalNameList = new List<string>();

                //奖项加1
                if (SampleLottery.NextPrize() == Error.ErrSuccess)
                {
                    //刷新页面内容
                    clearNameList();
                    labelPrizeName.Text = SampleLottery.getNowPrizeName();
                    pictureBox1.Image = SampleLottery.getNowImage();
                }
                else
                {
                    //已经结束，显示结束页面
                    clearNameList();
                    labelPrizeName.Text = "";
                    pictureBox1.Image = Resource1.picWishes;
                    buttonNextPage.Text = "关闭";
                    buttonBeginStop.Visible = false;
                }

                
            }
            else if (buttonNextPage.Text == "关闭")
            {
                this.Close();
            }
            else
            {
                //错误
            }
        }


        /* 首先将窗体的边框样式修改为None，让窗体没有标题栏
         * 实现这个效果使用了三个事件：鼠标按下、鼠标弹起、鼠标移动
         * 鼠标按下时更改变量isMouseDown标记窗体可以随鼠标的移动而移动
         * 鼠标移动时根据鼠标的移动量更改窗体的location属性，实现窗体移动
         * 鼠标弹起时更改变量isMouseDown标记窗体不可以随鼠标的移动而移动
         */
        private bool isMouseDown = false;
        private Point FormLocation;     //form的location
        private Point mouseOffset;      //鼠标的按下位置

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }

       

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;

                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }

        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
