using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public static void Marks<t>(double mark1, double mark2, double mark3, double mark4, double mark5) {
            
            double average = ((mark1 + mark2 + mark3 + mark4 + mark5) / 5); //The average of 5 marks
            Console.WriteLine("The Average For the 5 Marks is: " + average);


            double[] marksArr = { mark1, mark2, mark3, mark4, mark5 }; //insert marks into array to get the above and below average

            List<double> aboveAverage = new List<double>(); //List to add marks above average
            List<double> belowAverage = new List<double>(); //List to add marks below average

            for (int i = 0; i < marksArr.Length; i++) // for loop to get he above and below average
            {
                if (marksArr[i] > average)
                {
                    aboveAverage.Add(marksArr[i]);
                }
                else if (marksArr[i] < average)
                {
                    belowAverage.Add(marksArr[i]);
                }
            }

            double[] above = aboveAverage.ToArray(); //convert aboveAverage list to array
            Console.Write("Marks Above Average is: ");

            for (int i = 0; i < above.Length; i++) //for loop to print above value/s
            {
                Console.Write(above[i] + " ");
            }

            double[] below = belowAverage.ToArray(); //convert belowAverage list to array
            Console.Write("\nMarks Below Average is: ");

            for (int i = 0; i < above.Length; i++)  //for loop to print below value/s
            {
                Console.Write(below[i]);
            }
            Console.WriteLine("");
        


    }
        static void Main(string[] args)
        {
            Console.Write("Enter first Mark: ");
            double Mark1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second Mark: ");
            double Mark2 = double.Parse(Console.ReadLine());

            Console.Write("Enter third Mark: ");
            double Mark3 = double.Parse(Console.ReadLine());

            Console.Write("Enter fourth Mark: ");
            double Mark4 = double.Parse(Console.ReadLine());

            Console.Write("Enter fifth Mark: ");
            double Mark5 = double.Parse(Console.ReadLine());

            Marks<double>(Mark1, Mark2, Mark3, Mark4, Mark5);


        }
    }
}
