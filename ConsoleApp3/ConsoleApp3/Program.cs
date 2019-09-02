using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public class student {
        public string _name { get; set; }

        public student(string name)
        {
            _name = name;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var studentlist=new List<student> {new student("Jack"), new student("Tom"), new student("Mary"), new student("Peter") };


            //var result = from n in studentlist
            //             where n._name.Equals("Tom")
            //             select n._name;

            var result = studentlist.Where(n => n._name.Equals("Tom")).Select(n => n._name);

            foreach (var n in result) {
                Console.WriteLine("尋找{0}成功", n);
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("尋找{0}成功", result.Single());
            Console.Read();


        }
    }
}
