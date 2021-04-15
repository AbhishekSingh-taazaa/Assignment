using Lift.Delegates;
using Lift.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.Entites
{
   public class Person
    {
        public event ButtonPressedForCallingTheLift ButtonPressed;
        public int CurrentFloor { get; set; }
        public int DestinationFloor { get; set; }

        public WaitingStatus WaitingStatus { get; set; }

        public Direction DirectionToGoIn{ get
            {

                return CurrentFloor > DestinationFloor ? Direction.GoingDown : Direction.GoingUp;
            } }

        public Person(int currentfloor , int destinationfloor) {

            this.CurrentFloor = currentfloor;
            this.DestinationFloor = destinationfloor;
           this.WaitingStatus = WaitingStatus.Waiting;

        }

        public void PressButton() {

           // Console.WriteLine("Button Pressed In Person");
            this.ButtonPressed(this.DirectionToGoIn);
            
        
        }
    }
}
