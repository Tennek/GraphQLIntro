using GraphQL.SystemTextJson;
using System;
using System.Threading.Tasks;

namespace GraphQLIntro.Ex2
{
    public static class Example2
    {
        public static async Task HelloWorldExample()
        {
            var schema = new HelloWorldSchema();

            var json = await schema.ExecuteAsync(_ =>
            {
                _.Query = "{ hello }";
            });

            Console.WriteLine(json);
        }
    }
}
