using GraphQL.Types;
using System.Linq;

namespace GraphQLIntro.Ex4
{
    public class RootQuery : ObjectGraphType<object>
    {
        public RootQuery()
        {
            Name = "Query";

            Field<PizzaQuery>("singlePizza",
                resolve: context => PizzaDatabase.GetAllPizza().First()
            );

            Field<ListGraphType<PizzaQuery>>("allPizza",
                resolve: context => PizzaDatabase.GetAllPizza()
            );

        }
    }

    public class PizzaQuery : ObjectGraphType<Pizza>
    {
        public PizzaQuery()
        {
            Name = "Pizza";
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Price);
        }
    }
}
