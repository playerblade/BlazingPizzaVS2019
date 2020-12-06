using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingPizzaVS2019.Abstracts;

namespace BlazingPizzaVS2019.Models
{
    public class SausagePizza : PizzaBuilder
    {
        protected override void BuildCost()
        {
            pizza.SetCost(5);
        }

        protected override void BuildCoverage()
        {
            pizza.SetCoverage("Sausage");
        }
    }
}
