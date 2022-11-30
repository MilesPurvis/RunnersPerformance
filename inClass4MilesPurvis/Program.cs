/*
 * Program: inClass Lab 4: Arrays
 * 
 * Purpose: Program to provide stats to coach regarding athlete performance.
 * 
 * Revision-History:
 *  Created By Miles Puris
 *  Novemebr 09 2022
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inClass4MilesPurvis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare 2D Array namesAndTimes with 5 elements containg 2 elements
            string[,] namesAndTimes = new string[5, 2];

            Console.WriteLine("[Enter Runners Names and Times]\n");

            //for loop asks for user to enter runner name.
            for (int i = 0; i < namesAndTimes.GetLength(0); i++)
            {
                Console.Write("Enter Runner: ");
                namesAndTimes[i, 0] = Console.ReadLine();

                //Nested loop asks for time then breaks out to parent loop.
                for (int j = 0; j < 1; j++)
                {
                    Console.Write("Enter Time: ");
                    namesAndTimes[i, 1] = Console.ReadLine();
                }
            }

            //Ouput Average Pace:
            //Declare sumOfTimes and averagePace
            double sumOfTimes = 0;
            double averagePace;

            //for loop loops through namesAndTimes,
            //Converts to double and adds that number to sumOfTimes until it reaches length of the array
            for (int i = 0; i < namesAndTimes.GetLength(0); i++)
            {
                sumOfTimes += Convert.ToDouble(namesAndTimes[i, 1]);
            }

            //average pace divides the sumOfNumbers by the array length (5)
            averagePace = sumOfTimes / namesAndTimes.Length;

            //Outputs average pace to console.
            Console.WriteLine("\nThe Average Pace is: {0} Seconds", averagePace);

            //Declare int for number of runner slower and faster than avg.
            int faster = 0;
            int slower = 0;

            //for loop converts each time entry [-,1] to a double,
            //checks if it is < averagePace then adds 1 to the counter int faster else add 1 to slower
            for (int j = 0; j < namesAndTimes.GetLength(0); j++)
            {
                if (Convert.ToDouble(namesAndTimes[j, 1]) < averagePace)
                {
                    faster++;
                }
                else
                {
                    slower++;
                }

            }

            //Prints the total count of runners faster than the averagePace
            Console.WriteLine("\nThere are {0} runners faster than {1} Seconds", faster, averagePace);
            //Prints the total count of runners slower than the averagePace
            Console.WriteLine("\nThere are {0} runners slower than {1} Seconds", slower, averagePace);

            //Declare fastestTime as the index 0 time (first time)
            //Declare winnerTime and winnerName as emptry strings.
            double fastestTime = Convert.ToDouble(namesAndTimes[4, 1]);
            string winnerName = "";
            string winnerTime = "";
            int winnerIndex = 0;

            // for loop goes throught the array and if the time is < fastestTime that is the new fastest time.
            // winnerName and winnerTime are the corresponding runners name and time for fastest time.
            for (int j = 0; j < namesAndTimes.GetLength(0); j++)
            {
                if (Convert.ToDouble(namesAndTimes[j, 1]) < fastestTime)
                {
                    fastestTime = Convert.ToDouble(namesAndTimes[j, 1]);
                    //fastest time & Name of Winner:
                    winnerName = namesAndTimes[j, 0];
                    winnerTime = namesAndTimes[j, 1];
                    //index position of the winner with the fastest time.
                    winnerIndex = j;
                }
            }

            //Prints Winner to console.(winnerName, winnerIndex and winnerTime)
            Console.WriteLine("\n{0} in index position [{1}] won with a time of {2} Seconds", winnerName, winnerIndex, winnerTime);

            Console.ReadLine();
        }
    }
}
