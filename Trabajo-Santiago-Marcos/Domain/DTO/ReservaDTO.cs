using Trabajo_Santiago_Marcos.Domain.Entities;

namespace Trabajo_Santiago_Marcos.Domain.DTO
{
    public class ReservaDTO
    {
        public int CantidadPersonas { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Estado { get; set; }
        public virtual RangoReserva IdRangoReservaNavigation { get; set; }

    }
}
