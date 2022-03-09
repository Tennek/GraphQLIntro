using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLHotChocolat.Ex4
{
    public static class PizzaDatabase
    {
        public static IEnumerable<Pizza> GetAllPizza()
        {
            return new[]
            {
                new Pizza() {Id = 123, Name = "Peperroni", Price = 6.05, Ingredients = new [] { new Ingredient()  { Id = 1, Name = "Salami", SpicyRating = 2 }, new Ingredient()  { Id = 2, Name = "Cheese", SpicyRating = 0 } } },
                new Pizza() {Id = 456, Name = "Quatro stagioni", Price = 7.50, Ingredients = new [] { new Ingredient()  { Id = 3, Name = "Cheddar", SpicyRating = 0 }, new Ingredient()  { Id = 4, Name = "Mozarella", SpicyRating = 0 } } },
                new Pizza() {Id = 789, Name = "Frutti del mare", Price = 8.75, Ingredients = new [] { new Ingredient()  { Id = 5, Name = "Clams", SpicyRating = 1 }, new Ingredient()  { Id = 2, Name = "Cheese", SpicyRating = 0 } } },
            };
        }
    }

    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
    }

    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SpicyRating { get; set; }
    }
}
