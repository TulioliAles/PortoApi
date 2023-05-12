using Microsoft.AspNetCore.Mvc;
using PortoApi.DTOs;
using PortoApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortoApi.Services.Interfaces
{
    public interface IMovimentacaoService
    {
        public Task<ActionResult<Movimentacao>> AdicionarMovimentacaoAsync(MovimentacaoDto movimentacaoInput);
        public Task<ActionResult<Movimentacao>> AlterarTipoDeMovimentacaoAsync(int id, string tipo);
        public Task<ActionResult<Movimentacao>> AlterarDataEHorarioMovimentacaoAsync(int id, DateTime inicio, DateTime fim);
        public Task<ActionResult<Movimentacao>> ReceberMovimentacaoPorIdAsync(int id);
        public Task<ActionResult<List<Movimentacao>>> ReceberMovimentacaoPorClienteAsync(string cliente);
        public Task<ActionResult<List<Movimentacao>>> ReceberMovimentacaoPorContainerAsync(string numeroDeContainer);
        public Task<ActionResult> RemoverMovimentacaoAsync(int id);
    }
}
