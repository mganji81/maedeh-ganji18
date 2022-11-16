//برنامه ای بنویسید که سن یک فرد را برحسب روز از کاربر دریافت کرده سال و ماه و هفته و روز ان را نمایش دهد
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number1;
            int year, month, week, day;
            Console.WriteLine("please enter a number:");
            Number1 = Convert.ToInt32(Console.ReadLine());
            year = Number1 / 365;
            Number1 %= 365;
            month = Number1 / 30;
            Number1 %= 30;
            week = Number1 / 7;
            Number1 %= 7;
            day = Number1;
            Console.WriteLine("your age is:" + year + " years and " + month + " month and " + week + " weeks and " + day + " days ");
            Console.ReadKey();




        }
    }
}
