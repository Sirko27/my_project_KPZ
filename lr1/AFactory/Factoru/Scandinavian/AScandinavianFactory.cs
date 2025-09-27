using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory
{
    public class AScandinavianFactory : AChairFactory
    {
        public override ABarChair createABarChair()
        {
            return new BarChairScandinavian();
        }
        public override AGardenСhair createAGardenChair()
        {
            return new GardenChairScandinavian();
        }
        public override AKitchenChair createAKitchenChair()
        {
            return new KitchenChairScandinavian();
        }
    }
}
