using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCost.Toppings
{
    internal class Paneer:Topping
    {
        private Pizza _pizza;
        public override string name
        {
            get
            {
                return "Paneer";
            }
        }

        public Paneer()
        {

        }

        public Paneer(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override float GetCost()
        {
            return _pizza == null ? 60 : 60 + _pizza.GetCost();
        }

        public override string GetDescription()
        {
            return _pizza == null ? name : _pizza.GetDescription() + "+" + name;
        }
    }
}
