using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoJoggersKata
{
   public class Kata
    {
        public static Tuple<int, int> NumberOfLaps(int bobLap , int charlesLap) {

            int BobLap = bobLap;
            int CharleLap = charlesLap;
            int CommonFactor = 1;

            while (bobLap != charlesLap)
            {
                if (bobLap > charlesLap)
                {
                    bobLap = bobLap - charlesLap;
                }
                else
                {
                    charlesLap = charlesLap - bobLap;
                }
            }

            CommonFactor = (BobLap * CharleLap) / bobLap;
            BobLap = CommonFactor / BobLap;
            CharleLap = CommonFactor / CharleLap;




            return new Tuple<int, int>(BobLap, CharleLap); }
    }
}
