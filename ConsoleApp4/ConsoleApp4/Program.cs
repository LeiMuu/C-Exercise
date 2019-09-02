using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{

    class Program
    {

        static void Main(string[] args)
        {
            int[] score = new int[] { 89, 45, 100, 78, 60, 54, 37, 88, 21, 67, 54, 45, 39 };
            List<int> ScoreList = new List<int>(score);
            Console.WriteLine("顯示所有成績:");
            showScores(ScoreList);

            string opt = "0";

            while (opt != "-1")
            {
                Console.WriteLine("查詢功能: 1)大於幾分 2)小於幾分 :");
                try
                {
                    opt = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("輸入的不是數字");
                    continue;
                }

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("篩選大於幾分: ");
                        inputscores(opt, ScoreList);
                        continue;
                    case "2":
                        Console.WriteLine("篩選小於幾分: ");
                        inputscores(opt, ScoreList);
                        continue;
                    case "-1":
                        Console.WriteLine("離開功能表");
                        break;
                    default:
                        Console.WriteLine("無此選項");
                        continue;
                }

            }
            Console.Read();
        }
        public static void showScores(IEnumerable<int> ScoreList)
        {
            Console.WriteLine("------------------");
            foreach (int score in ScoreList)
            {
                Console.WriteLine("{0} ", score);
            }

        }
        public static void inputscores(string opt, List<int> ScoreList)
        {
            string score;int sc = 0;
            score = Console.ReadLine();
            while (true)
            {
                try
                {
                    sc=int.Parse(score);
                    break;
                }
                catch
                {
                    Console.WriteLine("輸入的不是數字, 在試一次: ");
                }
            }
            IEnumerable<int> result= ScoreList;
            if (opt == "1")
            {
                result = ScoreList.OrderByDescending(s => s).Where(s => s >= sc).Select(s => s);
            }
            if (opt == "2")
            {
                result = ScoreList.OrderByDescending(s => s).Where(s => s <= sc).Select(s => s);
            }
            showScores(result);
            Console.WriteLine("總和: {0}|平均: {1}|最大: {2}|最小: {3}|數量: {4}", result.Sum(), result.Average(), result.Max(), result.Min(), result.Count());
        }

    }
}
