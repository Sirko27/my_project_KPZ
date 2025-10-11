using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class builderBurger2 : IBuilder
    {
        private Burger _burger = new Burger();

        public void Reset()
        {
            this._burger = new Burger();
        }
        public builderBurger2()
        {
            this.Reset();
        }

        public void setBread()
        {
            this._burger.Bread = "Пшеничний";
        }
        public void setSauce()
        {
            this._burger.Sauce = "Кетчуп";
        }
        public void setTomato()
        {
            this._burger.Tomato = "0";
        }
        public void setSalad()
        {
            this._burger.Salad = "2";
        }
        public void setMeat()
        {
            this._burger.Meat = "Курятина";
        }
        public void setCheese()
        {
            this._burger.Cheese = "1";
        }

        public Burger getResult()
        {
            Burger result = this._burger;
            this.Reset();
            return result;
        }
    }
}
