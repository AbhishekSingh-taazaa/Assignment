using Lift.Entites;
using System;

namespace Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] rawInput = new int[][] {
                new int[]{ } , //0
                new int[0], //1
                new int[] {4},  //2
                new int[]{0},  //3
                new int[0], //4
                 new int[0] , //5
                new int[0], //6
                  new int[0] , //7
                new int[] {5,4,6} //8

            };

            int liftCapacity = 4;

            var building = new Building(liftCapacity, rawInput);

           

           
        }
    }
}
