using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace houseAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] house = { 1041,1062,1327,1483,1900,2112,2345,3210,3600,3601,4725,6217,9280 };
            double[] annualIncome = { 12180,13240,19800,24458,17000,19125,17623,5200,9500,11970,
                9800,10000,8200};
            int[] householdMember = { 4,3,2,8,2,7,2,6,5,2,3,2,1};

            double total = 0.0;
            double average = 0.0;
            //part a
            Console.WriteLine("ID" + "      " + "Income" + "      " + "Members");
            for (int x = 0; x < house.Length; x++)
            {
                Console.Write(house[x] + "      ");
                Console.Write(annualIncome[x] + "      ");
                Console.Write(householdMember[x] + "      ");
                Console.WriteLine();
            }


            //part b
            foreach (int x in annualIncome)
            {
                total += x;
            }
            average = total / annualIncome.Length;
            Console.WriteLine("Average income: " + average);
            Console.WriteLine("Household Id's and Incomes exceeding the average: ");
            for (int x = 0; x < house.Length; x++)
            {
                if (annualIncome[x] > average)
                {
                    Console.Write(house[x] + " ");
                    Console.WriteLine(annualIncome[x]);
                }
            }

            //percentage below poverty line
            //P = $7500.000 + $950.00 x (m - 2) where m is the number of members in each household
            double totalHouseholdsBelow = 0.0;
            for (int b = 0; b < house.Length; b++)
            {
                double povertyLine = 7500.0 + 950.0 * (householdMember[b] - 2);
                if (povertyLine > annualIncome[b])
                {
                    totalHouseholdsBelow = totalHouseholdsBelow + 1;
                }
            }
            double percentageBelPovLine = totalHouseholdsBelow / annualIncome.Length;
            Console.WriteLine("Percentage Below Poverty Line: " + percentageBelPovLine*100);

            Console.ReadLine();

        }
    }
}
