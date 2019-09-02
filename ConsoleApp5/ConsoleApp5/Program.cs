using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] books = { "noob", "noob_master", "noob2", "master", "pop_push", "push_master_noob", "masteryooooooooo", "yooNOOBooy", "YmasterSSSSS"};
            List<string> BookList = new List<string>(books);
            Console.WriteLine("顯示所有書籍:");
            showbooks(BookList);

            string key="";
            Console.WriteLine("關鍵字查詢:");

            key=Console.ReadLine();
            var result = BookList.Where(b => b.Contains(key));
            showbooks(result);

            Console.WriteLine("\n取得第一筆紀錄:");
            var result2 = BookList.Where(b => b.Contains(key)).FirstOrDefault();
            Console.WriteLine("{0} ", result2);

            string index="";
            Console.WriteLine("------------------");
            foreach (string book in BookList.Where(b => b.Contains(key)))
            {
                Console.WriteLine("{0} ", book);
            }
            Console.WriteLine("\n取得第幾筆紀錄(未排, 未做防爆):");
            index=Console.ReadLine();

            var result3 = BookList.Where(b => b.Contains(key)).Skip(int.Parse(index)-1).FirstOrDefault();
            Console.WriteLine("\n{0} ", result3);
        }
        public static void showbooks(IEnumerable<string> BookList)
        {
            Console.WriteLine("------------------");
            var bookSort = BookList.OrderByDescending(b => b);
            foreach (string book in bookSort)
            {
                Console.WriteLine("{0} ", book);
            }

        }
    }
}
