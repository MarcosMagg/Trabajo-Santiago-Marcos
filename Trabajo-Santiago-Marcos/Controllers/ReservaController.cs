using Microsoft.AspNetCore.Mvc;
using Trabajo_Santiago_Marcos.Service.Interface;

namespace Trabajo_Santiago_Marcos.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {

        private IReservaService _ReservaService;

        public ReservaController(IReservaService reservaService)
        {
            _ReservaService = reservaService;
        }


        [HttpGet]
        public async Task<IActionResult> GetReservas()
        {
            var result = await _ReservaService.GetAllReservasAsync();
            return Ok(result);
        }








    }
}
