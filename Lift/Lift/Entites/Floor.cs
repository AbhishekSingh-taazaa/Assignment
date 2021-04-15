using Lift.Delegates;
using Lift.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.Entites
{
   public class Floor
    {
        public event ButtonPressedForCallingTheLiftOnAGivenFloor ButtonPressedForCallingTheLift;
        public int FloorNumber { get; set; }

        public List<Person> PeopleWaitingForLift { get; set; }

        public List<Person> PeopleBelongToTheFloor { get; set; }

        public Floor(int floornumber ,int[] floorNumbersPeopleWantToGoTo) {

            FloorNumber = floornumber;
            PeopleWaitingForLift = floorNumbersPeopleWantToGoTo.Select(floorNumbersPersonWantToGoTo =>
            {

                var person = new Person(floornumber, floorNumbersPersonWantToGoTo);
                person.ButtonPressed += this.ButtonPress; 
                return person;

            }
            ).ToList();
        
        }

        public void ButtonPress(Direction direction) {
           // Console.WriteLine("Now We are in on Floor");
            this.ButtonPressedForCallingTheLift(direction , this.FloorNumber, this.PeopleWaitingForLift);
        }

        
    }
}
