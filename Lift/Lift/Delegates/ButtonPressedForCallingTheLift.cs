using Lift.Entites;
using Lift.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.Delegates
{
  
        public delegate void ButtonPressedForCallingTheLift(Direction direction);
        public delegate void ButtonPressedForCallingTheLiftOnAGivenFloor(Direction direction, int callingFloor, List<Person> PeopleWaitingForLift);
    
}
