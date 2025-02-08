using Persistence.Context;
using RestBot.Domain.Entities;
using RestBotDemo.Application.Repositories;

namespace RestBot.Persistence.EF_Core
{
    //ALTTAKI KODU CHECK ET BASEREPOSITORY<REZERVATİON> KISMINI
    public class RezervationRepository : BaseRepository<Reservation>, IReservationRepository
    {

        public RezervationRepository(AppDbContext context) : base(context)
        {
        }
        public Task AddAsync(Reservation entity)
        {
            return AddAsync(entity);
        }

        public Task DeleteAsync(int id)
        {
            return DeleteAsync(id);
        }

        public Task UpdateAsync(Reservation entity)
        {
            return UpdateAsync(entity);
        }

        public Task<IEnumerable<Reservation>> GetAllAsync()
        {
            return GetAllAsync();
        }
    }
}
