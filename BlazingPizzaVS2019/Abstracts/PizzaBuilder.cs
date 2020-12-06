using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingPizzaVS2019.Models;
using BlazingPizzaVS2019.Classes;

namespace BlazingPizzaVS2019.Abstracts
{
    public abstract class PizzaBuilder
    {
        public Pizza pizza { get; set; }

        public void MakeNewPizza()
        {
            pizza = new Pizza();
        }

        protected abstract void BuildCost();
        protected abstract void BuildCoverage();
        public void BuildCoverages(List<PizzaBuilder> coverages)
        {
            pizza.SetCoverages(coverages);
        }
        public void BuildDough(string dough)
        {
            pizza.SetDough(dough);
        }
        public void BuildSize(Size size)
        {
            pizza.SetSize(size);
        }
    }
}
