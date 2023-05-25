using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.net
{


    internal class Program
    {


        class speed1
        {
            public const int a = 6;
            public const int b = 10;

        }


        static void Main(string[] args)
        {



            //Console.WriteLine("Enter Name :");
            //string Name1 = Console.ReadLine();
            //Console.WriteLine("Enter Age :");
            //int Age1 =int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Time :");
            //int Time1=int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //string Name2 = Console.ReadLine();
            //Console.WriteLine("Enter Age");
            //int Age2 =int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Time :");
            //int Time2 = int.Parse(Console.ReadLine());




            //int sum_age = Age1 + Age2;
            //var Res="";

            //Console.WriteLine("\n");

            //if (Age1 > Age2)
            //{
            //    Res = "this old is bigger  :" + Age1  ;
            //    //Console.WriteLine(Age1);
            //}
            //else
            //{
            //    Res = "this old is bigger  :" + Age2  ;
            //    Console.WriteLine(Age2);
            //}

            //Console.WriteLine("Name: " + Name1 + " \n" + "Age: " + Age1 + " \n" + "Time: " + Time1 + " \n" + " ----------------------- " +
            //    "\n" + "Name: " + Name2 + " \n" + "Age: " + Age2 + " \n" + "Time: " + Time2 + " \n " + "----------------- " +"\n"+
            //    "Total Age : " +  sum_age + "\n" + "older : " + Res);



            Console.WriteLine("Enter top speed");
            int Speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter top speed for car");
            int car = int.Parse(Console.ReadLine());

            if (car > Speed)
            {
                Console.WriteLine("لا توجد مخالفة");
            }
            else if (car > Speed + 6 || car >= Speed + 10)
            {
                Console.WriteLine("  مخالفة صغيرة");
            }
            else (car > Speed + 10)
            {
                Console.WriteLine("مخالفة كبيرة");
            }
        





            Console.Read();



        }
    }
}
