using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazingPizzaVS2019.Models;

namespace BlazingPizzaVS2019.Contexts
{
    public class PizzaContext: DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> data) : base(data)
        {

        }

        public DbSet<Pizza> Pizzas { get; set; }

    }
}
