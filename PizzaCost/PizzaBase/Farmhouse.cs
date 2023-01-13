using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCost.PizzaBase
{
    internal class Farmhouse : Pizza
    {
        Pizza _pizza;
        public override string name { get
            {
                return "FarmHouse";
            }
        }

        public Farmhouse()
        {

        }

        public Farmhouse(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override float GetCost()
        {
            return _pizza==null?150: 150+ _pizza.GetCost();
        }

        public override string GetDescription()
        {
            return _pizza == null ? name : _pizza.GetDescription() + "+" + name;
        }
    }
}
