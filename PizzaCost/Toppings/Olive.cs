using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCost.Toppings
{
    internal class Olive : Topping
    {
        private Pizza _pizza;
        public override string name
        {
            get
            {
                return "Olive";
            }
        }

        public Olive()
        {

        }

        public Olive(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override float GetCost()
        {
            return _pizza==null?20: 20+ _pizza.GetCost();
        }

        public override string GetDescription()
        {
            return _pizza == null ? name : _pizza.GetDescription() + "+" + name;
        }
    }
}
