using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumConsecutives
{
   public class Kata
    {
        public static List<int> SumConsecutive(List<int> filteringList) {

           

            List<int> localList = new List<int>();

            for (int i=0;i<(filteringList.Count())-1;i++) {

                if (filteringList[i] == filteringList[i + 1])
                {
                    int sum = filteringList[i];
                    int j = i;
                    if (j == filteringList.Count() - 1)
                    {
                        localList.Add(sum);
                        break;
                    }
                    while (filteringList[j] == filteringList[j + 1])
                    {

                        sum += filteringList[j + 1];
                        if (j == filteringList.Count() - 1)
                            break;
                        else
                        j++;
                    }
                    localList.Add(sum);
                    i = j;

                }
                else {
                    localList.Add(filteringList[i]);
                }
                if (filteringList.Last() != filteringList[filteringList.Count - 2])
                {
                    int a = filteringList.Last();
                    localList.Add(a);
                    break;
                }


            }

         
         

            localList.ForEach(x=>Console.WriteLine(x));

            return localList;
        }
    }
}
