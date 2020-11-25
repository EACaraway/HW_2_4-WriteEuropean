using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkWeek2Problem4_method_w_European
{
    class Program                                                                       // Evan Caraway, Srinivas Reddy Doma, Kipack Jeong
    {
        static void Main(string[] args)
        {
            Console.Write("Enter day: ");
            string day = Console.ReadLine();
            Console.Write("Enter date: ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month: ");
            string month = Console.ReadLine();
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            WriteEuropean(day, date, month, year);                                      // Call method WriteEuropean in main.
        }

        static void WriteEuropean(string day, int date, string month, int year)         // Method that prints day, date, month and year in European format.
        {
            Console.WriteLine($"The current date is {day} {date} {month}, {year}.");
        }
    }
}
