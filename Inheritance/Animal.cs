using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{   
    internal class Animal
    { 
        public bool NeedsToEat { get; set; }
        public bool CanMove { get; set; }
        public bool NeedsRespiration { get; set; }
        public bool CanGrow { get; set; }
        
        public string AnimalFacts()
        {
            return "Here are some interesting animal facts! Every animal that reaches maturity needs to eat, has the ability to move at least a little, will grow, and needs to do some form of respiration.";
        }
    }
   
}
