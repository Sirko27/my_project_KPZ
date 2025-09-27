using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Building_House_Classic : Construction
    {
        public override House buildingHouse()
        {
            return new Classic { Material = "Granite", numberFloors = 2 };
        }
    }
}
