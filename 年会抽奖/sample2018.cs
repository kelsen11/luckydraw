using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 年会抽奖
{
    /// <summary>
    /// 程序背景
    /// </summary>
    public static class BgScreen
    {
        public static void Init()
        {

        }

        public static string GetBgImg()
        {
            return Application.StartupPath + "\\img\\bg2018.png";
        }
    }

    /// <summary>
    /// 用于软件启动生成随机数种子
    /// </summary>
    public static class SeedRand
    {
        public static Random Rand;

        public static void Init()
        {
            long tick = DateTime.Now.Ticks;
            Rand = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
        }

        public static int GetRandomSeed()
        {
            return Rand.Next(1, 99999999);
        }

        public static int GetRandomPosition(int maxnum)
        {
            return Rand.Next(0, maxnum);
        }
    }

    /* sample2018 抽奖使用案例*/
    public static class SampleLottery
    {
        private static string p1 = Application.StartupPath + "\\list\\1.txt";
        private static string p2 = Application.StartupPath + "\\list\\2.txt";
        private static string p3 = Application.StartupPath + "\\list\\3.txt";
        private static string p4 = Application.StartupPath + "\\list\\4.txt";
        private static string px = Application.StartupPath + "\\list\\x.txt";

        private static string choujiangjieguo = Application.StartupPath + "\\抽奖结果.txt";

        private static int thePoolOfBigPrizeId = 5;
        private static int thePool1Id = 0;
        private static int thePool2Id = 1;
        private static int thePool3Id = 2;
        private static int thePool4Id = 3;
        private static int thePoolxId = 4;

        /*在下面定义奖池*/
        public static List<PrizePool> pool_list = new List<PrizePool>();
        public static List<Prize> prize_list = new List<Prize>();

        private static int RightNowOrder = 0;

        private static int seed = 99;   //临时使用

        public static string DrawTitleString = "Sample2018 年会抽奖";


        /// <summary>
        /// 下一个奖项
        /// </summary>
        public static Error NextPrize()
        {
            if (RightNowOrder == prize_list.Count -1)
            {
                return Error.ErrNotFound;
            }

            RightNowOrder++;
            return Error.ErrSuccess;
        }


        

        public static void Init()
        {
            /****初始化奖池****/
            /*单独抽奖池子*/
            pool_list.Add(new PrizePool(p1, SeedRand.GetRandomSeed(), 1));  //0
            pool_list.Add(new PrizePool(p2, SeedRand.GetRandomSeed(), 1));//1
            pool_list.Add(new PrizePool(p3, SeedRand.GetRandomSeed(), 1));//2
            pool_list.Add(new PrizePool(p4, SeedRand.GetRandomSeed(), 1));//3
            pool_list.Add(new PrizePool(px, SeedRand.GetRandomSeed(), 1));//4-------共5个单独奖池

            //大奖总池子
            pool_list.Add(new PrizePool(p1, SeedRand.GetRandomSeed(), 1));
            pool_list[thePoolOfBigPrizeId].AddFileToPool(p2, 1);
            pool_list[thePoolOfBigPrizeId].AddFileToPool(p3, 1);
            pool_list[thePoolOfBigPrizeId].AddFileToPool(p4, 1);

            /****初始化奖项****/
            //NO2 华为mate10
            prize_list.Add(new Prize("华为 Mate10(1个)"));
            prize_list[0].AddPool(thePoolOfBigPrizeId, 1);
            prize_list[0].AddImg(Application.StartupPath + "\\img\\p2.png");

            //NO3 bose耳机
            prize_list.Add(new Prize("Bose耳机(1个)"));
            prize_list[1].AddPool(thePoolOfBigPrizeId, 1);
            prize_list[1].AddImg(Application.StartupPath + "\\img\\p3.png");

            //NO4 戴森吸尘器
            prize_list.Add(new Prize("戴森吸尘器(1个)"));
            prize_list[2].AddPool(thePoolOfBigPrizeId, 1);
            prize_list[2].AddImg(Application.StartupPath + "\\img\\p4.png");

            //NO5 iRobot
            prize_list.Add(new Prize("iRobot扫地机器人(1个)"));
            prize_list[3].AddPool(thePoolOfBigPrizeId, 1);
            prize_list[3].AddImg(Application.StartupPath + "\\img\\p5.png");

            //NO6 周大福
            prize_list.Add(new Prize("周大福狗年吊坠(5个)"));
            prize_list[4].AddImg(Application.StartupPath + "\\img\\p6.png");

            prize_list[4].AddPool(thePool1Id, 1);
            prize_list[4].AddPool(thePool2Id, 1);
            prize_list[4].AddPool(thePool3Id, 1);
            prize_list[4].AddPool(thePool4Id, 1);
            prize_list[4].AddPool(thePoolxId, 1);


            //NO7 华为b3手环
            prize_list.Add(new Prize("华为B3手环(5个)"));
            prize_list[5].AddImg(Application.StartupPath + "\\img\\p7.png");

            prize_list[5].AddPool(thePool1Id, 1);
            prize_list[5].AddPool(thePool2Id, 1);
            prize_list[5].AddPool(thePool3Id, 1);
            prize_list[5].AddPool(thePool4Id, 1);
            prize_list[5].AddPool(thePoolxId, 1);

            //NO8 小米旅行箱
            prize_list.Add(new Prize("小米90分铝镁合金旅行箱(2个)"));
            prize_list[6].AddImg(Application.StartupPath + "\\img\\p8.png");
            prize_list[6].AddPool(thePoolOfBigPrizeId, 2);

            //NO9 雷蛇机械键盘
            prize_list.Add(new Prize("雷蛇机械键盘(2个)"));
            prize_list[7].AddImg(Application.StartupPath + "\\img\\p9.png");
            prize_list[7].AddPool(thePoolOfBigPrizeId, 2);

            //NO10 jbl 蓝牙音箱
            prize_list.Add(new Prize("JBL GO 蓝牙音箱(20个)"));
            prize_list[8].AddImg(Application.StartupPath + "\\img\\p10.png");
            prize_list[8].AddPool(thePool1Id, 4);
            prize_list[8].AddPool(thePool2Id, 4);
            prize_list[8].AddPool(thePool3Id, 4);
            prize_list[8].AddPool(thePool4Id, 4);
            prize_list[8].AddPool(thePoolxId, 4);

            //NO11 小米智能床头灯
            prize_list.Add(new Prize("小米智能床头灯(10个)"));
            prize_list[9].AddImg(Application.StartupPath + "\\img\\p11.png");
            prize_list[9].AddPool(thePool1Id, 2);
            prize_list[9].AddPool(thePool2Id, 2);
            prize_list[9].AddPool(thePool3Id, 2);
            prize_list[9].AddPool(thePool4Id, 2);
            prize_list[9].AddPool(thePoolxId, 2);

            //NO12 造作套碗
            prize_list.Add(new Prize("造作茶花套碗(10个)"));
            prize_list[10].AddImg(Application.StartupPath + "\\img\\p12.png");
            prize_list[10].AddPool(thePool1Id, 2);
            prize_list[10].AddPool(thePool2Id, 2);
            prize_list[10].AddPool(thePool3Id, 2);
            prize_list[10].AddPool(thePool4Id, 2);
            prize_list[10].AddPool(thePoolxId, 2);

            //NO13 米乔靠背
            prize_list.Add(new Prize("米乔人体工学腰靠(20个)"));
            prize_list[11].AddImg(Application.StartupPath + "\\img\\p13.png");
            prize_list[11].AddPool(thePool1Id, 4);
            prize_list[11].AddPool(thePool2Id, 4);
            prize_list[11].AddPool(thePool3Id, 4);
            prize_list[11].AddPool(thePool4Id, 4);
            prize_list[11].AddPool(thePoolxId, 4);

            //NO1 iPhone X
            prize_list.Add(new Prize("iPhone X(1部)"));
            prize_list[12].AddImg(Application.StartupPath + "\\img\\p1.png");
            prize_list[12].AddPool(thePoolOfBigPrizeId, 1);

        }

        
        /// <summary>
        /// 获取获奖者
        /// </summary>
        /// <returns></returns>
        public static List<string> getWinner()
        {
            List<string> winner = new List<string>();

            foreach(PoolIdAndPrizeNum item in prize_list[RightNowOrder].ItemList)
            {
                //抽取所有数量的奖项
                /*
                for (int pNum = 0;pNum<item.PrizeNum;pNum++)
                {
                    string tmp = "";
                    pool_list[item.PoolId].ExtracOnePersonNoRepeat(out tmp);
                    //将奖项放入返回list中
                    winner.Add(tmp);
                }
                */

                //一次性抽取多名人员
                List<string> tmpwin = new List<string>();
                pool_list[item.PoolId].ExtracPersonNoRepeat(item.PrizeNum, out tmpwin);

                foreach (string theTmpName in tmpwin)   //将其加入到winner list中
                {
                    winner.Add(theTmpName);
                }

            }

            /*随机乱序*/
            if (winner.Count > 1)
            {
                for (int xyz= 0; xyz < winner.Count;xyz++)
                {
                    int order = SeedRand.GetRandomPosition(winner.Count);
                    string get1 = winner[order];
                    winner.RemoveAt(order);
                    winner.Add(get1);
                }
            }

            //返回
            return winner;
        }

        public static string getNowPrizeName()
        {
            return prize_list[RightNowOrder].Text;
        }

        public static System.Drawing.Image getNowImage()
        {
            return prize_list[RightNowOrder].Img;
        }
        

        //抽取一个
        /*
        public static string getOneWinner()
        {
            string winner = "";

            pool_all.ExtracOnePersonNoRepeat(out winner);

            return winner;
        }
        

        //抽取10个
        public static List<string> getTenWinner()
        {
            List<string> winner = new List<string>();
            string tmp = "";

            pool_iot.ExtracOnePersonNoRepeat(out tmp);
            winner.Add(tmp);
            pool_lvzhou.ExtracOnePersonNoRepeat(out tmp);
            winner.Add(tmp);
            pool_test.ExtracOnePersonNoRepeat(out tmp);
            winner.Add(tmp);
            pool_soft.ExtracOnePersonNoRepeat(out tmp);
            winner.Add(tmp);
            pool_ac.ExtracOnePersonNoRepeat(out tmp);
            winner.Add(tmp);
            pool_ap.ExtracOnePersonNoRepeat(out tmp);
            winner.Add(tmp);
            pool_added.ExtracOnePersonNoRepeat(out tmp);
            winner.Add(tmp);
            pool_waixie1.ExtracOnePersonNoRepeat(out tmp);
            winner.Add(tmp);
            pool_waixie2.ExtracOnePersonNoRepeat(out tmp);
            winner.Add(tmp);
            pool_waixie3.ExtracOnePersonNoRepeat(out tmp);
            winner.Add(tmp);


            //随机乱序，不行则关掉
            for (int i = 0; i < 10; i++)
            {
                int order = SeedRand.GetRandomPosition();
                string get1 = winner[order];
                winner.RemoveAt(order);
                winner.Add(get1);
            }

            return winner;
        }
        */

        /*
        public static List<string> getTenNum()
        {
            List<string> winner = new List<string>();
            for (int i = 0;i<10;i++)
            {
                winner.Add(pool_hongbao.GetPoolRandomNum().ToString());
            }
            return winner;
        }

        public static void SetTotalPersonNum(int num)
        {
            pool_hongbao.SetPoolMaxNum(num);
        }
        */

        public static void addPrizeResult(List<string> person)
        {
            string prizestring = DateTime.Now.ToLocalTime().ToString() +"\t\t"+ prize_list[RightNowOrder].Text;
            //将奖项写入名单
            FileStream fs = new FileStream(choujiangjieguo, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(prizestring);

            foreach(string pname in person)
            {
                sw.WriteLine(pname);
            }
            sw.WriteLine("");
            sw.Close();


            //添加到奖池黑名单
            foreach (PrizePool item in pool_list)
            {
                foreach (string pname in person)
                {
                    item.AddWinnerToResult(pname);
                }
            }
        }
    }

    
}
