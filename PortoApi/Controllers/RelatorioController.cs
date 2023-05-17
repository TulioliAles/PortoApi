using Microsoft.AspNetCore.Mvc;
using PortoApi.Models;
using PortoApi.Services.Interfaces;
using System.Threading.Tasks;

namespace PortoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelatorioController : ControllerBase
    {
        private readonly IRelatorioService _service;

        public RelatorioController(IRelatorioService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Relatorio>> GerarRelatorioFinalAsync()
            => await _service.GerarRelatorioFinalAsync();
    }
}
