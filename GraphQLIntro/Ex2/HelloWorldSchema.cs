using GraphQL.Types;

namespace GraphQLIntro.Ex2
{
    public class HelloWorldSchema : Schema
    {
        public HelloWorldSchema()
        {
            this.Query = GetQuery();
        }

        private IObjectGraphType GetQuery()
        {
            return new RootQuery();
        }
    }

    public class RootQuery : ObjectGraphType<object>
    {
        public RootQuery()
        {
            Name = "Query";

            Field("hello", context =>
                "hello from my schema"
            );
        }
    }
}
