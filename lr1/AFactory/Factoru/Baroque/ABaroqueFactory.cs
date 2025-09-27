using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory
{
    public class ABaroqueFactory : AChairFactory
    {
        public override ABarChair createABarChair()
        {
            return new BarChairBaroque();
        }
        public override AGardenСhair createAGardenChair()
        {
            return new GardenChairBaroque();
        }
        public override AKitchenChair createAKitchenChair()
        {
            return new KitchenChairBaroque();
        }
    }
}
