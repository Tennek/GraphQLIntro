using HotChocolate;
using HotChocolate.Execution;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLHotChocolat.Ex5
{
    public static class Example5
    {
        public async static Task Start()
        {
            var schema = SchemaBuilder.New()
                .AddQueryType<QueryType>()
                .AddType<PizzaType>()
                .AddType<IngredientType>()
                .Create();

            var executor = schema.MakeExecutable();

            Console.WriteLine("Chocolat example 4:");

            //the prefix "Get..." is not used
            Console.WriteLine((await executor.ExecuteAsync("{ pizzaById(id:789) { id name ingredients { name spicyRating id } } }")).ToJson());
        }
    }

    public class Query
    {
        public Pizza GetSinglePizza()
        {
            return PizzaDatabase.GetAllPizza().First();
        }

        public IEnumerable<Pizza> GetAllPizza()
        {
            return PizzaDatabase.GetAllPizza();
        }

        public Pizza GetPizzaById(int id)
        {
            return PizzaDatabase.GetAllPizza().FirstOrDefault(x => x.Id.Equals(id));
        }
    }

    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(t => t.GetSinglePizza())
                .Type<PizzaType>();

            descriptor.Field(t => t.GetAllPizza())
                .Type<ListType<PizzaType>>();

            descriptor.Field(t => t.GetPizzaById(default))
                .Type<PizzaType>()
                .Argument("id", x => x.Type<IntType>());
        }
    }

    public class PizzaType : ObjectType<Pizza>
    {
        protected override void Configure(IObjectTypeDescriptor<Pizza> descriptor)
        {
            descriptor.Name("Pizza");

            descriptor.Field(p => p.Id)
                .Type<IntType>();

            descriptor.Field(p => p.Name)
                .Type<StringType>();

            descriptor.Field(p => p.Price)
                .Type<DecimalType>();

            descriptor.Field(p => p.Ingredients)
                .Type<ListType<IngredientType>>();
        }
    }

    public class IngredientType : ObjectType<Ingredient>
    {
        protected override void Configure(IObjectTypeDescriptor<Ingredient> descriptor)
        {
            descriptor.Name("Ingredient");

            descriptor.Field(p => p.Id)
                .Type<IntType>();

            descriptor.Field(p => p.Name)
                .Type<StringType>();

            descriptor.Field(p => p.SpicyRating)
                .Type<IntType>();
        }
    }
}
