using GraphQL;
using GraphQL.SystemTextJson;
using System;
using System.Threading.Tasks;

namespace GraphQLIntro.Ex5
{
    public static class Example5
    {
        public static async Task WithComplexList()
        {
            var schema = new PizzaSchema();

            var json = await schema.ExecuteAsync(_ =>
            {
                _.Query = "{ allPizza { id name ingredients { name spicyRating } } }";
            });

            Console.WriteLine(json);
        }
    }
}
