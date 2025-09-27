using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public abstract class House
    {
        public string Style;
        public string Material;
        public int numberFloors;

        public string getInfo()
        {
            return "Style: " + Style + ", Material: " + Material + ", Number Floors: " + numberFloors;
        }

        public abstract void draw();
    }
}
