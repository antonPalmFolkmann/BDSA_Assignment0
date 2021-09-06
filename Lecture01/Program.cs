using System;

namespace Lecture01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static bool isLeapYear(int year){
            if (year % 400 == 0){
                return true;
            }
            else if (year % 100 == 0){
                return false;
            }
            else return year % 4 == 0;
        }
    }
}
