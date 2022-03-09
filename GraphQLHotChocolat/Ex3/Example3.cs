using HotChocolate;
using HotChocolate.Execution;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLHotChocolat.Ex3
{
    public static class Example3
    {
        public async static Task Start()
        {
            var schema = SchemaBuilder.New()
                .AddQueryType<QueryType>()
                .AddType<PizzaType>()
                .Create();

            var executor = schema.MakeExecutable();

            Console.WriteLine("Chocolat example 3:");

            //the prefix "Get..." is not used
            Console.WriteLine((await executor.ExecuteAsync("{ singlePizza { id name } }")).ToJson());
        }
    }

    public class Query
    {
        public Pizza GetSinglePizza()
        {
            return PizzaDatabase.GetAllPizza().First();
        }
    }

    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(t => t.GetSinglePizza())
                .Type<PizzaType>();
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
        }
    }
}
