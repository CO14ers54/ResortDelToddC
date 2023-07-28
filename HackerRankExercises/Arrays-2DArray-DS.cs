using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExercises
{
    class Arrays_2DArray_DS
    {
        public static void Arrays_2DArray_DS_Exercise()
        {
            int[,] arr = new int[6,6]{ {1,1,1,0,0,0},
                           {0,1,0,0,0,0},
                           {1,1,1,0,0,0},
                           {0,0,0,0,0,0},
                           {0,0,0,0,0,0},
                           {0,0,0,0,0,0}};
            int[,] arr2 = new int[6,6]
                          { {-9,-9,-9,0,0,0},
                           {0,-9,0,4,3,2},
                           {-9,-9,-9,1,1,1},
                           {0,0,8,6,6,0},
                           {0,0,0,-2,0,0},
                           {0,0,1,2,4,0}};

            //int maxSum = HourglassMaxSum(arr2);

            //Console.WriteLine("The max hourglass sum is: " + maxSum);
        }

        private static int HourglassMaxSum(int[][] arr)
        {
            int maxSum = int.MinValue;
            
            for (int y = 0; y <= 3; y++)
            {
                for (int x = 0; x <= 3; x++)
                {
                    // Get the sum of the top row of the hourglass
                    int sumForHourGlass = arr[y][x] + arr[y][x+1] + arr[y][x+2];

                    // Now, for the middle row
                    sumForHourGlass += arr[y + 1][x + 1];

                    // Finally, add in the sum of the bottom row
                    sumForHourGlass += arr[y + 2][x] + arr[y + 2][x + 1] + arr[y + 2][x + 2];

                    if (sumForHourGlass > maxSum)
                    {
                        maxSum = sumForHourGlass;
                    }
                }
            }

            return maxSum;
        }
    }
}
