using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLIntro.Ex4
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
