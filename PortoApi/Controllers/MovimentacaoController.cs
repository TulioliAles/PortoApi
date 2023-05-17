using Microsoft.AspNetCore.Mvc;
using PortoApi.DTOs;
using PortoApi.Models;
using PortoApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimentacaoController : ControllerBase
    {
        private readonly IMovimentacaoService _service;

        public MovimentacaoController(IMovimentacaoService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("adicionar")]
        public async Task<ActionResult<Movimentacao>> AdicionarMovimentacaoAsync(MovimentacaoDto movimentacaoInput)
            => await _service.AdicionarMovimentacaoAsync(movimentacaoInput);

        [HttpPut]
        [Route("alterar/tipo")]
        public async Task<ActionResult<Movimentacao>> AlterarTipoDeMovimentacaoAsync(int id, string tipo)
            => await _service.AlterarTipoDeMovimentacaoAsync(id, tipo);

        [HttpPut]
        [Route("alterar/data")]
        public async Task<ActionResult<Movimentacao>> AlterarDataEHorarioMovimentacaoAsync(int id, DateTime inicio, DateTime fim)
            => await _service.AlterarDataEHorarioMovimentacaoAsync(id, inicio, fim);

        [HttpGet]
        [Route("id")]
        public async Task<ActionResult<Movimentacao>> ReceberMovimentacaoPorIdAsync(int id)
            => await _service.ReceberMovimentacaoPorIdAsync(id);

        [HttpGet]
        [Route("receber/cliente")]
        public async Task<ActionResult<List<Movimentacao>>> ReceberMovimentacaoPorClienteAsync(string cliente)
            => await _service.ReceberMovimentacaoPorClienteAsync(cliente);

        [HttpGet]
        [Route("receber/container")]
        public async Task<ActionResult<List<Movimentacao>>> ReceberMovimentacaoPorContainerAsync(string numeroDeContainer)
            => await _service.ReceberMovimentacaoPorContainerAsync(numeroDeContainer);

        [HttpDelete]
        [Route("remover")]
        public async Task<ActionResult> RemoverMovimentacaoAsync(int id)
            => await _service.RemoverMovimentacaoAsync(id);
    }
}
