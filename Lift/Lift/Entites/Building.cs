using Lift.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.Entites
{
   public class Building
    {
        public Floor[] Floors { get; set; }

        public Lift Lift { get; set; }

        public Building(int liftCapacity,int[][] floorAndPeopleComposition) {

             this.Floors = floorAndPeopleComposition.Select((floorComposition, floorNumber) =>
                  {
                      var floor = new Floor(floorNumber, floorComposition);
                      floor.ButtonPressedForCallingTheLift += LiftRequested;
                      return floor;
                  }).ToArray();
            this.Lift = new Lift(liftCapacity, this.Floors.Length);

        }

       public void Liftstart() {

            foreach (Floor floor in Floors) {

                floor.PeopleWaitingForLift.ForEach(p =>

                {
                    if (p.WaitingStatus == WaitingStatus.Waiting)
                    {
                        p.PressButton();

                    }
                
                });
               
            }

            this.Lift.MoveToTop();
            this.Lift.MoveToGround();
            Console.WriteLine($"Stopped On:{this.Lift.CurrentFloor}");

        }

        public void LiftRequested(Direction direction, int floorNumberRequestedOn, List<Person> peopleWaiting)
        {
           // Console.WriteLine("Lift is Requested");
            Console.WriteLine("Lift Stopped On "+floorNumberRequestedOn+" Floor");

            this.Lift.LiftManager(direction, floorNumberRequestedOn);

            peopleWaiting.ForEach(person => {

                if (person.DestinationFloor > this.Lift.CurrentFloor)
                {
                    person.WaitingStatus = WaitingStatus.OnBoarding;
                    
                    this.Lift.People.Add(person);
                    
                }
                else if (person.DestinationFloor < this.Lift.CurrentFloor)
                {
                    person.WaitingStatus = WaitingStatus.OnBoarding;
                    this.Lift.People.Add(person);
                }
            });
           
        }
    }
}
