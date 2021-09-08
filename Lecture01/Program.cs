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

        public static void userInputValidator(){
            Console.WriteLine("Input year to check if it is a leap year:");
            var input = Convert.ToInt32(Console.ReadLine());

            if (isLeapYear(input)){
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            }
        }
    }
}
