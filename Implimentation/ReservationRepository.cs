using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Model;

namespace GraphQLProject.Implimentation
{
    public class ReservationRepository : IReservationRepository
    {

        private readonly AppDbContext appDbContext;

        public ReservationRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public Reservation AddReservation(Reservation reservation)
        {

            appDbContext.reservation.AddAsync(reservation);
            appDbContext.SaveChanges();
            return reservation;
            
        }

        public List<Reservation> GetReservations()
        {
            return appDbContext.reservation.ToList();
        }
    }
}
