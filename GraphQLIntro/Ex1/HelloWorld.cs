using GraphQL.SystemTextJson;
using GraphQL.Types;
using System;
using System.Threading.Tasks;

namespace GraphQLIntro.Ex1
{
    public static class Example1
    {
        public static async Task HelloWorldExample()
        {
            var schema = Schema.For(@"
              type Query {
                hello: String
              }
            ");

            var root = new { Hello = "Hello World!" };
            var json = await schema.ExecuteAsync(_ =>
            {
                _.Query = "{ hello }";
                _.Root = root;
            });

            Console.WriteLine(json);
        }
    }
}
