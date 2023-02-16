using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public int AverageNumEggsLaid { get; set; }
        public bool HasWings { get; set; }
        public string MainFeatherColor { get; set; }
        public string PreferredFood { get; set; }
    }
}
