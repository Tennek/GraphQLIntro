using HotChocolate;
using HotChocolate.Execution;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLHotChocolat.Ex1
{
    public static class Example1
    {
        public static async Task HelloWorldExample()
        {
            var schema = SchemaBuilder.New()
                .AddQueryType<Query>()
                .Create();

            var executor = schema.MakeExecutable();

            Console.WriteLine("Chocolat example 1:");
            Console.WriteLine((await executor.ExecuteAsync("{ hello }")).ToJson());
        }
    }

    public class Query
    {
        public string Hello() => "World !";
    }
}
