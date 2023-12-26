using Trabajo_Santiago_Marcos.Domain.DTO;
using Trabajo_Santiago_Marcos.Domain.Entities;

namespace Trabajo_Santiago_Marcos.Service.Interface
{
    public interface IReservaService
    {
        public Task<List<Reserva>> GetAllReservasAsync();
        public Task<bool> AddReservaAsync(Reserva reserva);
        public Task<bool> RemoveReservaAsync(int id);
        public Task<bool> UpdateReservaAsync(int id, ReservaDTO reserva);
    }
}
