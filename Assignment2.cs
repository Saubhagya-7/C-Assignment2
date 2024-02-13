using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE2
{
    internal class Assignment2
    {
        static void Main(string[] args)
        {
            double[] lowerBounds = { 2, 0, -10 };
            double[] upperBounds = { 3, 1, -2 };

            Console.Write("Enter a real number: ");
            double x = Convert.ToDouble(Console.ReadLine());

            bool belongsToI = false;

            for (int i = 0; i < 3; i++)
            {
                if ((x >= lowerBounds[i] && x < upperBounds[i]) || (x > lowerBounds[i] && x <= upperBounds[i]))
                {
                    belongsToI = true;
                    break;
                }
            }

            if (belongsToI)
            {
                Console.WriteLine("x belongs to I");
            }
            else
            {
                Console.WriteLine("x does not belong to I");
            }
        }
    }
}
