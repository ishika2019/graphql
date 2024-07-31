using GraphQL.Types;

namespace GraphQLProject.Query
{
    public class RootQuery :ObjectGraphType
    {
        public RootQuery()
        {
            Field<MenuQuery>("menuQuery").Resolve(context => new { });
            Field<CategoryQuery>("CategoryQuery").Resolve(context => new { });
            Field<ReservationQuery>("ReservationQuery").Resolve(context=> new { }); 
        }
    }
}
