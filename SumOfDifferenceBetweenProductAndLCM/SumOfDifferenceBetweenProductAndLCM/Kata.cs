using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDifferenceBetweenProductAndLCM
{
    public class Kata
    {
        public static int SumOfDifferenceBetweenProductAndLCM(int [][] pairs) {
            int Result = 0;
            int[] MultiPlicationArray = new int[pairs.Length];
            int[] LCMArray = new int[pairs.Length];
            for (int i = 0; i < pairs.Length; i++)
            {
               
                int X = pairs[i][0];
                int Y = pairs[i][1];
                int firstValue = X;
                int secondValue =Y;


        
                while (firstValue != secondValue)
                {
                    if (firstValue > secondValue)
                    {
                        firstValue = firstValue - secondValue;
                    }
                    else
                    {
                        secondValue = secondValue - firstValue;
                    }

                   
                }
                LCMArray[i] = (X * Y) / firstValue;
              
                MultiPlicationArray[i] = X * Y;

                Result += (MultiPlicationArray[i] - LCMArray[i]);



            }

            return Result;
        }
    }
}
