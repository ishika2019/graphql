using GraphQLProject.Model;

namespace GraphQLProject.Interfaces
{
    public interface IReservationRepository
    {

        List<Reservation> GetReservations();

        Reservation AddReservation(Reservation reservation);

    }
}
