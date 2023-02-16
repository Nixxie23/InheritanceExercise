using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public int NumberOfLegs { get; set; }
        public bool HasForkedTongue { get; set; }
        public bool IsColdBlooded { get; set; }
        public string PreferredFood { get; set; }
    }
}
