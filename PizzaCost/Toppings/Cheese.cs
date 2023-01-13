using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCost.Toppings
{
    internal class Cheese:Topping
    {
        private Pizza _pizza;
        public override string name
        {
            get
            {
                return "Cheese";
            }
        }

        public Cheese()
        {

        }

        public Cheese(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override float GetCost()
        {
            return _pizza == null ? 80 : 80 + _pizza.GetCost();
        }

        public override string GetDescription()
        {
            return _pizza == null ? name : _pizza.GetDescription() + "+" + name;
        }
    }
}
