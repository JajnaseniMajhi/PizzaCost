using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCost
{
    internal abstract class Pizza
    {
      public abstract string name { get; }

      public abstract float GetCost();

      public abstract string GetDescription();
       

    }
}
