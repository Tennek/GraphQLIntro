using GraphQL;
using GraphQL.SystemTextJson;
using System;
using System.Threading.Tasks;

namespace GraphQLIntro.Ex6
{
    public static class Example6
    {
        public static async Task WithFetchById()
        {
            var schema = new PizzaSchema();

            var json = await schema.ExecuteAsync(_ =>
            {
                _.Query = "{ singlePizzaById(id: 123) { id name ingredients { name spicyRating } } }";
            });

            Console.WriteLine(json);
        }
    }
}
