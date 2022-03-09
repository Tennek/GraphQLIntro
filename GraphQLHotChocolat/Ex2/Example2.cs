using HotChocolate;
using HotChocolate.Execution;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLHotChocolat.Ex2
{
    public static class Example2
    {
        public static async Task HelloWorldExample()
        {
            var schema = SchemaBuilder.New()
                .AddQueryType<QueryType>()
                .Create();

            var executor = schema.MakeExecutable();

            Console.WriteLine("Chocolat example 2:");
            Console.WriteLine((await executor.ExecuteAsync("{ hello }")).ToJson());
        }
    }

    public class Query
    {
        public string Hello() => "world";
    }

    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(f => f.Hello()).Type<NonNullType<StringType>>();
        }
    }
}
