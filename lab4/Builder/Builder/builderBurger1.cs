using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Builder
{
    public class builderBurger1 : IBuilder
    {
        private Burger _burger = new Burger();
        public builderBurger1()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._burger = new Burger();
        }

        public void setBread()
        {
            this._burger.Bread = "Житній";
        }
        public void setSauce()
        {
            this._burger.Sauce = "Сирний";
        }
        public void setTomato()
        {
            this._burger.Tomato = "2";
        }
        public void setSalad()
        {
            this._burger.Salad = "1";
        }
        public void setMeat()
        {
            this._burger.Meat = "Свинина";
        }
        public void setCheese()
        {
            this._burger.Cheese = "2";
        }

        public Burger getResult()
        {
            Burger result = this._burger;
            this.Reset();
            return result;
        }
    }
}
