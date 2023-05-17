using Microsoft.AspNetCore.Mvc;
using PortoApi.DTOs;
using PortoApi.Models;
using PortoApi.Services.Interfaces;
using System.Collections.Generic;

using System.Threading.Tasks;

namespace PortoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContainerController : ControllerBase
    {
        private readonly IContainerService _service;

        public ContainerController(IContainerService service)
            => _service = service;

        [HttpPost]
        [Route("adicionar")]
        public async Task<ActionResult<Container>> AdicionarContainerAsync(ContainerDto containerInput) 
            => await _service.AdicionarContainerAsync(containerInput);

        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult<Container>> AlterarContainerAsync(string numeroDeSerie, string? status, string? categoria, string? cliente)
            => await _service.AlterarContainerAsync(numeroDeSerie, status, categoria, cliente);

        [HttpDelete]
        [Route("remover")]
        public async Task<ActionResult> RemoverContainerAsync(string numeroDeSerie)
            => await _service.RemoverContainerAsync(numeroDeSerie);

        [HttpGet]
        [Route("receber/numero")]
        public async Task<ActionResult<Container>> ReceberContainerPorNumeroDeSerieAsync(string numeroDeSerie)
            => await _service.ReceberContainerPorNumeroDeSerieAsync(numeroDeSerie);

        [HttpGet]
        [Route("receber/cliente")]
        public async Task<ActionResult<List<Container>>> ReceberContainerDeClienteAsync(string cliente)
            => await _service.ReceberContainerDeClienteAsync(cliente);

    }
}
