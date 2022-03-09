using GraphQL;
using GraphQL.SystemTextJson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLIntro.Ex4
{
    public static class Example4
    {
        public static async Task WithList()
        {
            var schema = new PizzaSchema();

            var json = await schema.ExecuteAsync(_ =>
            {
                _.Query = "{ allPizza { id name } }"; //only fetch id and name
            });

            Console.WriteLine(json);
        }
    }
}
