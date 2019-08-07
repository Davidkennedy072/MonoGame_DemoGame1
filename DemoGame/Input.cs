using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Creating Input class with 4 properities for 4 movements
//Each properity needs to be set with Keys

namespace DemoGame
{
    public class Input
    {
        public Keys Left { get; set; } // Using properties
        // same thing as defining public Keys Left variable and
        // adding get and set function. For right we use example

        public Keys Right { get; set; }
        public Keys Up { get; set; }
        public Keys Down { get; set; }
        
    }
}
