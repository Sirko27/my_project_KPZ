using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory
{
    public abstract class AChair
    {
        public string Hint;
        public string Reward;
        public string Size;
        public string Material;

        public string getInfo()
        {
            return "Підказка: " + Hint + "; Нагорода: " + Reward + "; Розмір: " + Size + "; Матеріал: " + Material;
        }

        public abstract void draw();
    }
}
