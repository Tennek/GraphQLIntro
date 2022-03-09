using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQLIntro.Ex3
{
    public class RootQuery : ObjectGraphType<object>
    {
        public RootQuery()
        {
            Name = "Query";

            Field<PizzaQuery>("singlePizza", 
                resolve: context => PizzaDatabase.GetAllPizza().First()
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
