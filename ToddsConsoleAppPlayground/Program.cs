using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToddsConsoleAppPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            DifferenceInDaysBetweenTwoDates();
            AddTwoNumbersUsingLinkedLists();
        }

        static void DifferenceInDaysBetweenTwoDates()
        {
            Console.WriteLine("Number of days between two dates.");

            string date1 = "2020-01-15";
            string date2 = "2019-12-31";

            string[] arrDate1 = date1.Split('-');
            string[] arrDate2 = date2.Split('-');

            DateTime dt1 = new DateTime(Convert.ToInt32(arrDate1[0]), Convert.ToInt32(arrDate1[1]), Convert.ToInt32(arrDate1[2]));
            DateTime dt2 = new DateTime(Convert.ToInt32(arrDate2[0]), Convert.ToInt32(arrDate2[1]), Convert.ToInt32(arrDate2[2]));

            Console.WriteLine("DateTime dt1: " + dt1.ToString());
            Console.WriteLine("DateTime dt2: " + dt2.ToString());

            Console.WriteLine("Difference in days is:  " + Math.Abs((dt1 - dt2).Days));

            Console.ReadLine();
        }

        static void AddTwoNumbersUsingLinkedLists()
        {
            int[] digits1 = { 2, 4, 3 };
            LinkedList<int> num1 = new LinkedList<int>(digits1);

            int[] digits2 = { 5, 6, 4 };
            LinkedList<int> num2 = new LinkedList<int>(digits2);
            string gus = num2.ToString();

            StringBuilder sb1 = ReverseOrder(num1);
            StringBuilder sb2 = ReverseOrder(num2);

            //Console.WriteLine("The sum is:  " + (one + two));
            Console.ReadLine();
        }

        private static StringBuilder ReverseOrder(LinkedList<int> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in list)
            {
                sb.Append(i.ToString(), 0, 1);
            }

            return sb;
        }
    }
}
