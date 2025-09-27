using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory
{
    public class BarChairBaroque : ABarChair
    {
        public BarChairBaroque()
        {
            //return "Підказка: " + Hint + "; Нагорода: " + Reward + "; Розмір: " + Size + "; Матеріал: " + Material;
            Hint = "скан...?";
            Reward = "0";
            Size = "70x35x34";
            Material = "wood";

        }

        public override void draw()
        {

        }

    }
}
