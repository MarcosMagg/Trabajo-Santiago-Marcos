using Microsoft.EntityFrameworkCore;
using Trabajo_Santiago_Marcos.Domain.DTO;
using Trabajo_Santiago_Marcos.Domain.Entities;
using Trabajo_Santiago_Marcos.Repository;
using Trabajo_Santiago_Marcos.Service.Interface;

namespace Trabajo_Santiago_Marcos.Service
{
    public class ReservaService : IReservaService
    {

        private readonly ReservaRestaurantContext _context;

        public ReservaService(ReservaRestaurantContext context)
        {
            _context = context; 
        }





        public Task<bool> AddReservaAsync(Reserva reserva)
        {
            
        }




        public async Task<List<Reserva>> GetAllReservasAsync()
        {
            return await _context.Reservas.ToListAsync();
        }




        public Task<bool> RemoveReservaAsync(int id)
        {
            throw new NotImplementedException();
        }



        public Task<bool> UpdateReservaAsync(int id, ReservaDTO reserva)
        {
            throw new NotImplementedException();
        }
    }
}
