using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Building_House_Romanesque : Construction
    {
        public override House buildingHouse()
        {
            return new Romanesque { Material = "Marble", numberFloors = 4 };
        }
    }
}
