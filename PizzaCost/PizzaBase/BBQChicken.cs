using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCost.PizzaBase
{
    internal class BBQChicken : Pizza
    {
        private Pizza _pizza;
        public override string name {
            get
            {
                return "BBQChicken";
            }
        }

        public BBQChicken()
        {

        }
        public BBQChicken(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override float GetCost()
        {
            return _pizza==null?200: 200+ _pizza.GetCost();
        }

        public override string GetDescription()
        {
            return _pizza == null ? name : _pizza.GetDescription() + "+" + name;
        }
    }
}
