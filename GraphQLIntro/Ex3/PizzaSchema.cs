using GraphQL.Types;

namespace GraphQLIntro.Ex3
{
    public class PizzaSchema : Schema
    {
        public PizzaSchema()
        {
            this.Query = GetQuery();
        }

        private IObjectGraphType GetQuery()
        {
            return new RootQuery();
        }
    }
}
