using Lift.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.Entites
{
   public class Lift
    {
        public int Capacity { get; set; }
        public List<Person> People { get; set; }
        public int CurrentFloor { get; set; }

        public int TopFloor { get;  }

        public Lift(int capacity,int topFloor) {
            this.CurrentFloor = 0;
            this.Capacity = capacity;
            this.TopFloor = topFloor;
            this.People = new List<Person>();

        }


       private void MoveUp(int requestedFloorToGo) {

           while (requestedFloorToGo > this.CurrentFloor && requestedFloorToGo <=this.TopFloor) {

                this.CurrentFloor++;

                List<Person> Newpeople = new List<Person>();
                this.People.ForEach(person =>
                {

                    person.CurrentFloor = this.CurrentFloor;
                    if (person.DestinationFloor == this.CurrentFloor) {

                        Console.WriteLine(person.DestinationFloor+" Reached");
                        person.WaitingStatus = WaitingStatus.Reached;
                    
                    }
                    else
                    {
                        Newpeople.Add(person);

                    }
                    this.People = Newpeople;


                }


                ); 


            }
            
            
        
        }

      private  void MoveDown(int requestedFloorToGo) {

            while (requestedFloorToGo < CurrentFloor && requestedFloorToGo > 0) {

                this.CurrentFloor--;
                List<Person> Newpeople = new List<Person>();
                this.People.ForEach(person =>
                {

                    person.CurrentFloor = this.CurrentFloor;
                    if (person.DestinationFloor == this.CurrentFloor)
                    {

                        Console.WriteLine(person.DestinationFloor + " Reached");
                        person.WaitingStatus = WaitingStatus.Reached;

                    }
                    else
                    {
                        Newpeople.Add(person);

                    }
                    this.People = Newpeople;


                }


                );


            }
        
        
        }


        public void MoveToTop() {

            if (this.People.Count >0) {

                while (this.CurrentFloor < this.TopFloor) {

                    this.CurrentFloor++;

                    List<Person> Newpeople = new List<Person>();
                    this.People.ForEach(person =>
                    {

                        person.CurrentFloor = this.CurrentFloor;
                        if (person.DestinationFloor == this.CurrentFloor)
                        {

                            Console.WriteLine(person.DestinationFloor + " Reached");
                            person.WaitingStatus = WaitingStatus.Reached;

                        }
                        else
                        {
                            Newpeople.Add(person);

                        }
                        this.People = Newpeople;


                    }


                    );
                }


            }
            else {

                this.MoveToGround();
            }
        }

        public void MoveToGround() {

            if (this.People.Count == 0)
            {
                this.CurrentFloor = 0;
            }
            else
            {
                while (this.CurrentFloor > 0)
                {
                    this.CurrentFloor--;
                    List<Person> Newpeople = new List<Person>();
                    this.People.ForEach(p =>
                    {
                        p.CurrentFloor = this.CurrentFloor;
                        if (p.DestinationFloor == this.CurrentFloor)
                        {
                            Console.WriteLine($"{p.DestinationFloor} Reached");
                            p.WaitingStatus = WaitingStatus.Reached;
                        }
                        else
                        {
                            Newpeople.Add(p);
                        }
                    });
                    this.People = Newpeople;
                }
            }
        }


        public void LiftManager(Direction direction,int requestedOnWhichFloor) {

            if (direction == Direction.GoingUp) {

                this.MoveUp(requestedOnWhichFloor);
            }
            else if (direction == Direction.GoingDown) {

                this.MoveDown(requestedOnWhichFloor);
            
            }
        
        }
    }
}
