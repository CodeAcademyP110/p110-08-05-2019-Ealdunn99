using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Random rannum = new Random();

            //int num, num2;

            //Console.WriteLine("enter number: ");
            //num = Convert.ToInt32(Console.ReadLine());

            ////for (int i = 1; i <= num; i++)
            ////{
            ////    Console.WriteLine("Value of i: {0}", i);
            ////}
            //num2 = rannum.Next(1,num);
            //Console.WriteLine(num2);
            //for (int i = 1; i <= num2; i++)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine("Value of i: {0}", i);
            //    }
            //}



            //int number = int.Parse(Console.ReadLine());
            //int count = 0;
            //int total = 0;
            //while (number > 0)
            //{
            //    total += number % 10;
            //    number /= 10;
            //    count++;

            //}
            //Console.WriteLine(total);
            //Console.WriteLine("say  " + count);




            // string text  = Console.ReadLine();
            //string at = "@";
            // Console.WriteLine(text.Contains(at));



            // Console.WriteLine(Console.ReadLine().Contains("@"));


            //if (Console.ReadLine().Contains("@"))
            //{
            //    Console.WriteLine("Düzgün email daxil etmisiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış email daxil etmisiniz");
            //}

            Console.WriteLine(Console.ReadLine().Contains("@") ? "Düzgün email daxil etmisiniz" : "Yanlış email daxil etmisiniz");


        }
    }
}
