using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Model;
using GraphQLProject.Type;

namespace GraphQLProject.Query
{
    public class ReservationQuery : ObjectGraphType<Reservation>
    {
        private readonly IReservationRepository reservationRepository;

        public ReservationQuery(IReservationRepository reservationRepository)
        {
            this.reservationRepository = reservationRepository;

            Field<ListGraphType<ReservationType>>("reservations").Resolve(context =>
            {
                return reservationRepository.GetReservations();
            });

        }



    }
}
