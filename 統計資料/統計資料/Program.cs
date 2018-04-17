using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 統計資料
{
    class Program
    {
        static void Main(string[] args)
        {
            //背景顏色
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;

            //螢幕延遲
            Console.Clear();
            System.Threading.Thread.Sleep(1000);

            //宣告資料
            string[] name = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] constellation = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "雙子", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            int[] heights = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };

            int countGirl = 0;
            int countMan = 0;
            int countA = 0;
            int countB = 0;
            int countAB = 0;
            int countO = 0;
            int sum = 0;
            int count = 0;
            int boy = 0;
            int girl = 0;

            //計算男女人數
            for (int i = 0; i < gender.Length; i++)
            {
                if (gender[i] == "女")
                {
                    girl++;
                }
                else if (gender[i] == "男")
                {
                    boy++;
                }
            }

            //計算血型人數
            for (int i = 0; i < blood.Length; i++)
            {
                if (blood[i] == "A")
                {
                    countA += 1;
                }
                else if (blood[i] == "B")
                {
                    countB += 1;
                }
                else if (blood[i] == "AB")
                {
                    countAB += 1;
                }
                else if (blood[i] == "O")
                {
                    countO += 1;
                }

            }

            //男女生身高總和
            int sumGirl = 0;
            int sumMan = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] > 100 && heights[i] < 200 && gender[i] == "女")
                {
                    sumGirl = sumGirl + heights[i];
                    countGirl++;
                }
                else if (heights[i] > 100 && heights[i] < 200 && gender[i] == "男")
                {
                    sumMan = sumMan + heights[i];
                    countMan++;
                }

            }

            //全班身高
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] > 100 && heights[i] < 200)
                {
                    sum = sum + heights[i];
                    count++;
                }
            }

            //計算最高和最矮身高
            int maxH = 0;
            int minH = 999;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] > 100 && heights[i] < 200)
                {
                    if (heights[i] > maxH)
                    {
                        maxH = heights[i];
                    }

                    if (heights[i] < minH)
                    {
                        minH = heights[i];
                    }
                }
            }

            //男女身高平均
            double Gph = sumGirl / countGirl;
            double Mph = sumMan / countMan;
            double average = sum / count;

            //百分比
            double perMan = (double)countMan / (double)gender.Length * 100;
            double perGirl = (double)countGirl / (double)gender.Length * 100;
            double perA = (double)countA / (double)blood.Length * 100;
            double perB = (double)countB / (double)blood.Length * 100;
            double perAB = (double)countAB / (double)blood.Length * 100;
            double perO = (double)countO / (double)blood.Length * 100;

            //顯示
            Console.WriteLine("女生人數:{0} 佔:{1:0}%", countGirl, perGirl);
            Console.WriteLine("男生人數:{0} 佔:{1:0}%", countMan, perMan);
            Console.WriteLine("女生身高總合為:" + sumGirl + "，平均為:" + Gph);
            Console.WriteLine("男生身高總合為:" + sumMan + "，平均為:" + Mph);
            Console.WriteLine("全部身高總合為:" + sum + "，平均為:" + average);
            Console.WriteLine("班上最高身高:" + maxH);
            Console.WriteLine("班上最矮身高:" + minH);
            Console.WriteLine("A型人數:{0} 佔:{1:0}%", countA, perA);
            Console.WriteLine("B型人數:{0} 佔:{1:0}%", countB, perB);
            Console.WriteLine("AB型人數:{0} 佔:{1:0}%", countAB, perAB);
            Console.WriteLine("O型人數:{0} 佔:{1:0}%", countO, perO);

            //計算天蠍座O型的人
            for (int i = 0; i < name.Length; i++)
            {
                if (constellation[i] == "天蠍" && blood[i] == "O")
                {
                    Console.WriteLine("天蠍座O型的人:" + name[i]);
                }
            }



            Console.ReadLine();
        }
    }
}
