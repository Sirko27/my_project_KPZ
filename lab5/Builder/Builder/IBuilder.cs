using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        void Reset();
        void setBread();
        void setSauce();
        void setTomato();
        void setSalad();
        void setMeat();
        void setCheese();
        Burger getResult();
    }
}
