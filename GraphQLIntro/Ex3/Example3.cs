using GraphQL.SystemTextJson;
using System;
using System.Threading.Tasks;

namespace GraphQLIntro.Ex3
{
    public static class Example3
    {
        public static async Task WithObject()
        {
            var schema = new PizzaSchema();

            var json = await schema.ExecuteAsync(_ =>
            {
                _.Query = "{ singlePizza { id name } }"; //only fetch id and name
            });

            //var json = await schema.ExecuteAsync(_ =>
            //{
            //    _.Query = "{ singlePizza { price } }"; //only fetch price
            //});

            Console.WriteLine(json);
        }
    }
}
