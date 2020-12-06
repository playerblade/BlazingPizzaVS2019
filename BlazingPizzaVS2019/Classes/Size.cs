using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizzaVS2019.Classes
{
    public class Size
    {
        public int Cost { get; set; }
        public string Lenght { get; set; }
        public Size(int cost, string lenght)
        {
            this.Cost = cost;
            this.Lenght = lenght;
        }
    }
}
