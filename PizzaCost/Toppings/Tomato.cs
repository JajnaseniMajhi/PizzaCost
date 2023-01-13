using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCost.Toppings
{
    internal class Tomato:Topping
    {
        private Pizza _pizza;
        public override string name
        {
            get
            {
                return "Tomato";
            }
        }

        public Tomato()
        {

        }

        public Tomato(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override float GetCost()
        {
            return _pizza == null ? 30 : 30 + _pizza.GetCost();
        }

        public override string GetDescription()
        {
            return _pizza == null ? name : _pizza.GetDescription() + "+" + name;
        }
    }
}
