using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory
{
    public abstract class AChairFactory
    {
        public abstract ABarChair createABarChair();
        public abstract AGardenСhair createAGardenChair();
        public abstract AKitchenChair createAKitchenChair();
    }
}
