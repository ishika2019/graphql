using GraphQL;
using GraphQL.Types;
using GraphQLProject.Implimentation;
using GraphQLProject.Interfaces;
using GraphQLProject.Model;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{
    public class ReservationMutation :ObjectGraphType
    {

        public ReservationMutation(IReservationRepository reservationRepository)
        {
            Field<ReservationType>("CreateReservation").Arguments(new QueryArguments(new QueryArgument<CategoryInputType> { Name = "reservation" })).Resolve(context =>
            {
                return reservationRepository.AddReservation(context.GetArgument<Reservation>("reservation"));
            });
        }
    }
}
