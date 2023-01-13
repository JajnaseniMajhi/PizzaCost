using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCost.PizzaBase
{
    internal class Pepperoni : Pizza
    {
        private Pizza _pizza;
        public Pepperoni()
        {
        }

        public Pepperoni(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string name
        {
            get
            {
                return "Pepperoni";
            }
        }

        public override float GetCost()
        {
            return _pizza==null?180: 180+ _pizza.GetCost();
        }

        public override string GetDescription()
        {
            return _pizza == null ? name : _pizza.GetDescription() + "+" + name;
        }
    }
}
