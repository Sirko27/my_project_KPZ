using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory
{
    public class AClassicFactory : AChairFactory
    {
        public override ABarChair createABarChair()
        {
            return new BarChairClassic();
        }
        public override AGardenСhair createAGardenChair()
        {
            return new GardenChairClassic();
        }
        public override AKitchenChair createAKitchenChair()
        {
            return new KitchenChairClassic();
        }
    }
}
