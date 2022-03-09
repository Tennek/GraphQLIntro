using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLHotChocolat.Ex3
{
    public static class PizzaDatabase
    {
        public static IEnumerable<Pizza> GetAllPizza()
        {
            return new[]
            {
                new Pizza() {Id = 123, Name = "Peperroni", Price = 6.05 },
                new Pizza() {Id = 456, Name = "Quatro stagioni", Price = 7.50 },
                new Pizza() {Id = 789, Name = "Frutti del mare", Price = 8.75 }
            };
        }
    }

    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
