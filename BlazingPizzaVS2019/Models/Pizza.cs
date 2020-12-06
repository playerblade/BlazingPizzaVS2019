using BlazingPizzaVS2019.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BlazingPizzaVS2019.Classes;

namespace BlazingPizzaVS2019.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Size Size { get; set; }
        private string Dough { get; set; }
        public int Cost { get; set; }
        public string Converge { get; set; }
        public List<PizzaBuilder> Coverages { get; set; }
        public Pizza()
        {
            this.Coverages = new List<PizzaBuilder>();
        }
        public void SetCost(int cost)
        {
            this.Cost = cost;
        }
        internal void SetDough(string dough)
        {
            this.Dough = dough;
        }

        internal void SetSize(Size size)
        {
            this.Size = size;
        }

        internal void SetCoverages(List<PizzaBuilder> coverages)
        {
            this.Coverages = coverages;   
        }
        public void SetCoverage(string coverage)
        {
            this.Converge = coverage;
        }
    }
}
