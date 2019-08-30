using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class member
    {
        public string id { get; set; }
        public string name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> listInt = new List<int>();
            listInt.Add(123); //存放123到目前List最尾端
            listInt.Add(789); //存放789到目前List最尾端 ---> listInt<123, 789>
            listInt.Insert(1, 456);//在索引1的位置將456插入, 789位置會往後擺 --->listInt<123, 456, 789>
            Console.WriteLine("=int 整數串列=");
            foreach (int num in listInt) {
                
                Console.WriteLine("listInt={0}\n", num);

            }

            for (int i = 0; i < listInt.Count; i++) {
                Console.WriteLine("listInt[{0}]={1}", i, listInt[i]);
            }
            /////////////////////////////////


            List<member> listmember = new List<member>();
            listmember.Add(new member() { id = "M01", name = "noob" });
            listmember.Add(new member() { id = "M02", name = "noob2" });
            listmember.Add(new member() { id = "M01", name = "noob3" });

            listmember.RemoveAt(1);
            Console.WriteLine("=member 成員串列=");

            for (int i = 0; i < listmember.Count; i++)
            {
                Console.WriteLine("listmember[{0}]=>id={1}, name= {2}", i, listmember[i].id, listmember[i].name);
            }


            Console.Read();
        }
    }
}
