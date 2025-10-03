using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set {  builder = value; }
        }

        public void builderBurger()
        {
            this.builder.setBread();
            this.builder.setSauce();
            this.builder.setTomato();
            this.builder.setSalad();
            this.builder.setMeat();
            this.builder.setCheese();
        }
    }
}
