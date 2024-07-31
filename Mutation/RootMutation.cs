using GraphQL.Types;

namespace GraphQLProject.Mutation
{
    public class RootMutation : ObjectGraphType
    {

        public RootMutation()
        {
            Field<CategoryMutation>("categoryMutaion");
            Field<ReservationMutation>("reservationMutation");
            Field<MenuMutation>("menuMutation");
        }
    }
}
