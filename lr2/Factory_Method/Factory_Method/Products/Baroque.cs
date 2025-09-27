using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Baroque : House
    {
        public Baroque() 
        {
            Style = "Baroque";
            Material = "";
            numberFloors = 0;
        }
        public override void draw()
        {
            
        }
    }
}
