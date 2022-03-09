using GraphQL;
using GraphQL.Types;
using System.Linq;

namespace GraphQLIntro.Ex6
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

            Field<PizzaQuery>("singlePizzaById",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "id of the pizza" }
                ),
                resolve: context => PizzaDatabase.GetAllPizza().FirstOrDefault(x => x.Id == context.GetArgument<int>("id"))
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

            Field<ListGraphType<IngredientQuery>>("Ingredients");
        }
    }

    public class IngredientQuery : ObjectGraphType<Ingredient>
    {
        public IngredientQuery()
        {
            Name = "Ingredients";
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.SpicyRating);
        }
    }
}
