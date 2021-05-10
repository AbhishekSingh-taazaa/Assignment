using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnoughIsEnough
{
  public  class Kata
    {
        public static int[] DeleteNth(int[] Arry, int MaxOccurence) {

        
            List<int> localList = new List<int>();
            for (int i=0; i< Arry.Length;++i) {
                
                if (localList.Count(item => item == Arry[i]) < MaxOccurence) {

                    localList.Add(Arry[i]);

                }
            
            }

            return localList.ToArray(); 
        }
    }
}
