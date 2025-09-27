using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Romanesque : House
    {
        public Romanesque()
        {
            Style = "Romanesque";
            Material = "";
            numberFloors = 0;
        }

        public override void draw()
        {

        }
    }
}
