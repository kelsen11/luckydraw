using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 年会抽奖
{

    public enum Error
    {
        ErrSuccess = 0, //成功
        ErrFailed,      //通用错误
        ErrNotFound,    //不存在

    }


    /// <summary>
    /// 名单类
    /// </summary>
    public class NameList
    {
        private List<string> Person = new List<string>();
        private int Weight;     /*权重：表示在奖池中出现的次数，越大概率越高，默认1*/

        public NameList()
        {
            Weight = 1;
        }

        /// <summary>
        /// 从文件添加person到名单中
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public Error AddPersonFromTxt(string filePath)
        {
            if(!File.Exists(filePath))
            {
                return Error.ErrNotFound;
            }

            //using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
            using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    if (s.Trim() != "")
                    {
                        Person.Add(s.Trim());   //添加到list中
                    }
                }
            }
            return Error.ErrSuccess;
        }

        

        /// <summary>
        /// 获取名单人数
        /// </summary>
        /// <returns>名单人数</returns>
        public int GetPersonNum()
        {
            return Person.Count;
        }

        /// <summary>
        /// 根据序号获取人名
        /// </summary>
        /// <param name="order">序号，从0开始</param>
        /// <param name="name">人名</param>
        /// <returns></returns>
        public Error GetPersonName(int order,out string name)
        {

            if (order >= 0 && order < Person.Count)
            {
                name = Person[order];
                return Error.ErrSuccess;
            }
            else
            {
                name = "";
                return Error.ErrFailed;
            }
        }

        /// <summary>
        /// 设置权重
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        public Error SetWeight(int weight)
        {
            /*权重限定在0~100之间*/
            /*
             0，表示不会中奖；
             大于0，表示在奖池中出现的次数
             */
            if (weight >= 0 && weight <= 100)
            {
                Weight = weight;
                return Error.ErrSuccess;
            }
            else
            {
                return Error.ErrFailed;
            }
        }

        /// <summary>
        /// 获取权重
        /// </summary>
        /// <returns></returns>
        public int GetWeight()
        {
            return Weight;
        }


    }

    public class PoolRandom
    {
        private Random Rand;
        private int RandomMax;      //随机数最大值

        public PoolRandom()
        {
            RandomMax = 1;
        }

        /// <summary>
        /// 根据种子构造奖池随机数类
        /// </summary>
        /// <param name="seed"></param>
        public PoolRandom(int seed)
        {
            this.Init(seed);
            RandomMax = 1;
        }

        /// <summary>
        /// 初始化随机数
        /// </summary>
        /// <param name="seed"></param>
        public void Init(int seed)
        {
            Rand = new Random(seed);
        }

        /// <summary>
        /// 设置随机数的最大值
        /// </summary>
        /// <param name="maxVal"></param>
        public void SetRandomMaxVal(int maxVal)
        {
            if (maxVal <= 0)
            {
                RandomMax = 1;
            }
            else
            {
                RandomMax = maxVal;
            }
        }

        /// <summary>
        /// 返回随机数
        /// </summary>
        /// <returns>随机数</returns>
        public int GetRandom()
        {
            return Rand.Next(0, RandomMax);     /*next方法中，可取最小值，不可取最大值，故max最小为1*/
        }
        
        public int GetRandom(int maxVal)
        {
            return Rand.Next(0, maxVal);
        }

        public int GetRandom(int minVal, int maxVal)
        {
            return Rand.Next(minVal, maxVal);
        }

        public int GetRandomWithMaxVal()
        {
            return Rand.Next(1, RandomMax + 1);
        }
    }
    public class PrizePool
    {
        private List<NameList> NameListArray = new List<NameList>(); //名单 数组
        private List<string> PrizeResultList = new List<string>();    //中奖结果

        private int PrizeNum;       //中奖数量

        private int PersonNum;      //奖池人数

        private PoolRandom PoolRand = new PoolRandom();    //奖池用于随机数获取的变量



        public PrizePool()
        {
            PrizeNum = 1;       //中奖数量默认为1
        }

        public PrizePool(string file, int seed, int winWeight)
        {
            InitRandomSeed(seed);

            AddFileToPool(file, winWeight);

        }



        /*
         * 初始化奖池随机数种子
         */

        public void InitRandomSeed(int seed)
        {
            PoolRand.Init(seed);
        }

        /// <summary>
        /// 映射所有名单人物到随机数（即确定随机数的最大值）
        /// </summary>
        /// <param name="maxRandomVal">得到的随机数最大值</param>
        /// <returns></returns>
        private Error MappingPersonToRandom(out int maxRandomVal)
        {
            if(NameListArray.Count == 0)
            {
                maxRandomVal = 1;
                return Error.ErrFailed;
            }

            /*计算包含权重的总人数*/
            int totalPersonNum = 0;
            int realityPersonNum = 0;
            for(int i = 0;i<NameListArray.Count;i++)
            {
                totalPersonNum += NameListArray[i].GetPersonNum() * NameListArray[i].GetWeight();
                realityPersonNum += NameListArray[i].GetPersonNum();
            }

            maxRandomVal = totalPersonNum;
            PersonNum = realityPersonNum;

            //优化：判断是否超过整数的最大值

            return Error.ErrSuccess;
        }

        /// <summary>
        /// 将随机数映射到人物（名单序号，名单中person序号）
        /// </summary>
        /// <param name="random"></param>
        /// <param name="nameListOrder">得到的名单序号</param>
        /// <param name="personOrder">得到的人物在名单中的序号</param>
        /// <returns></returns>
        private Error MappingRandomToPerson(int random, out int nameListOrder, out int personOrder)
        {
            if (NameListArray.Count == 0)
            {
                nameListOrder = 0;
                personOrder = 0;
                return Error.ErrFailed;
            }

            int totalPersonNum = 0;
            for (int i = 0; i < NameListArray.Count; i++)
            {
                totalPersonNum += NameListArray[i].GetPersonNum() * NameListArray[i].GetWeight();
                if (random < totalPersonNum) //注意随机数从0开始
                {
                    //计算并退出循环
                    nameListOrder = i;
                    /*核心公式*/
                    personOrder = NameListArray[i].GetPersonNum() - (int)((totalPersonNum - random - 1) / NameListArray[i].GetWeight()) - 1;

                    return Error.ErrSuccess;
                }
            }

            nameListOrder = 0;
            personOrder = 0;
            return Error.ErrFailed;
        }

        //获取人数
        private int GetPersonNum()
        {
            return PersonNum;
        }


        //抽取一个人
        public Error ExtracOnePerson(out string person)
        {
            //获取一个随机数
            int num = PoolRand.GetRandom();

            //映射到某个人
            int nameListOrder = 0;
            int personOrder = 0;
            Error err;
            err = MappingRandomToPerson(num, out nameListOrder, out personOrder);
            if(err != Error.ErrSuccess)
            {
                person = "";
                return err;
            }

            //获取人名
            string personName = "";
            err = NameListArray[nameListOrder].GetPersonName(personOrder, out personName);
            if(err != Error.ErrSuccess)
            {
                person = "";
                return err;
            }

            person = personName;
            return Error.ErrSuccess;
        }

        private bool IsGotPrize(string person)
        {
            for (int i = 0; i < PrizeResultList.Count; i++)
            {
                if (PrizeResultList[i] == person)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsGotPrizeInTmpList(List<string> personTmpList,string person)
        {
            for (int i = 0; i < personTmpList.Count; i++)
            {
                if (personTmpList[i] == person)
                {
                    return true;
                }
            }
            return false;
        }

        //抽取一个人（不重复）
        public Error ExtracOnePersonNoRepeat(out string person)
        {
            Error err;
            int i = 0;
            do
            {
                err = ExtracOnePerson(out person);
                i++;
                //} while ((err == Error.ErrSuccess) && IsGotPrize(person) && PrizeResultList.Count < PersonNum);
            } while ((err == Error.ErrSuccess) && IsGotPrize(person) && i < 100000);    //超过10w次需要退出
            return err;
        }

        //抽取不重复n人
        public Error ExtracPersonNoRepeat(int num,out List<string> personList)
        {
            Error err = Error.ErrFailed;
            string person;

            List<string> alreadyExtracPersonList = new List<string>();
            
            for(int pNum= 0;pNum<num;pNum++)
            {
                //以下抽取一位
                int i = 0;
                do
                {
                    err = ExtracOnePerson(out person);
                    i++;
                    //} while ((err == Error.ErrSuccess) && IsGotPrize(person) && PrizeResultList.Count < PersonNum);
                } while (!((err == Error.ErrSuccess) && !IsGotPrize(person) && 
                !IsGotPrizeInTmpList(alreadyExtracPersonList,person)));    //超过10w次需要退出

                if((err == Error.ErrSuccess) && !IsGotPrize(person) &&
                !IsGotPrizeInTmpList(alreadyExtracPersonList, person) && i < 100000)
                {
                    //抽取成功写入list
                    alreadyExtracPersonList.Add(person);
                }
                else
                {
                    err = Error.ErrFailed;
                    break;
                }
            }

            personList = alreadyExtracPersonList;
            return err;
        }

        public void AddWinnerToResult(string person)
        {
            PrizeResultList.Add(person);
        }

        //根据获奖数量抽奖，并返回名单字符串（每行一位中奖者）


        //从文件添加名单到奖池，并更新映射关系。
        public Error AddFileToPool(string file,int winWeight)
        {
            NameList tmpList = new NameList();  //必须为新生成的变量
            Error err;

            /*注意出错时，一定不要将名单添加到奖池中*/

            //设置名单权重
            err = tmpList.SetWeight(winWeight);
            if (err != Error.ErrSuccess)
            {
                return err;
            }

            //读取名单
            err = tmpList.AddPersonFromTxt(file);
            if (err != Error.ErrSuccess)
            {
                return err;
            }

            //添加名单到pool中的名单数组
            NameListArray.Add(tmpList);

            int maxVal = 1;
            err = MappingPersonToRandom(out maxVal);
            if (err != Error.ErrSuccess)
            {
                return err;
            }

            //更新随机数上限值
            PoolRand.SetRandomMaxVal(maxVal);

            return Error.ErrSuccess;
        }

        //设置奖池随机数大小
        public void SetPoolMaxNum(int numVal)
        {
            PoolRand.SetRandomMaxVal(numVal);
        }

        //从奖池直接抽取随机数
        public int GetPoolRandomNum()
        {
            return PoolRand.GetRandomWithMaxVal();  //从1到最大值
        }

    }

    public class PoolIdAndPrizeNum
    {
        public int PoolId = 0;
        public int PrizeNum = 0;

        public PoolIdAndPrizeNum()
        {
            PoolId = 0;
            PrizeNum = 0;
        }

        public PoolIdAndPrizeNum(int poolid,int num)
        {
            PoolId = poolid;
            PrizeNum = num;
        }

    }

    public class Prize
    {
        public string Text = "";
        public System.Drawing.Image Img = Resource1.picNone;

        public List<PoolIdAndPrizeNum> ItemList = new List<PoolIdAndPrizeNum>();

        /*
        public List<int> poolIdList = new List<int>();
        public List<int> prizeNumList = new List<int>();
        */

        public  Prize(string Txt)
        {
            Text = Txt;
        }

        public void AddImg(string imgFilePath)
        {
            //这里可能会出异常
            Img = System.Drawing.Image.FromFile(imgFilePath);
        }

        /// <summary>
        /// 添加奖池
        /// </summary>
        /// <param name="PoolId"></param>
        /// <param name="PrizeNum"></param>
        public void AddPool(int PoolId,int PrizeNum)
        {
            ItemList.Add(new PoolIdAndPrizeNum(PoolId, PrizeNum));
        }

        /// <summary>
        /// 获取奖项总抽奖个数
        /// </summary>
        /// <returns></returns>
        public int GetAllPrizeNum()
        {
            int sum = 0;
            foreach(PoolIdAndPrizeNum s in ItemList)
            {
                sum += s.PrizeNum;
            }

            return sum;
        }

        /// <summary>
        /// 获取奖项中对应奖池个数
        /// </summary>
        /// <returns></returns>
        public int GetPoolListCount()
        {
            return ItemList.Count;
        }

        /// <summary>
        /// 获取奖池抽奖个数
        /// </summary>
        /// <param name="PoolNum">奖项中奖池序号</param>
        /// <returns></returns>
        public int GetPrizeNum(int PoolNum)
        {
            return ItemList[PoolNum].PrizeNum;
        }
    }
}
