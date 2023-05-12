using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortoApi.DTOs;
using PortoApi.Models;
using PortoApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortoApi.Services.Implementacoes
{
    public class MovimentacaoService : IMovimentacaoService
    {
        private readonly PortoDBContext _context;

        public MovimentacaoService(PortoDBContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<Movimentacao>> AdicionarMovimentacaoAsync(MovimentacaoDto movimentacaoInput)
        {
            Container container = await _context.Containers.AsNoTracking().FirstOrDefaultAsync(c => c.NumeroDeSerie == movimentacaoInput.NumeroDeContainer);

            if (container == null)
                return new BadRequestObjectResult(movimentacaoInput.NumeroDeContainer);

            Movimentacao movimentacao = new Movimentacao()
            {
                NumeroDeContainer = movimentacaoInput.NumeroDeContainer,
                Tipo = movimentacaoInput.Tipo,
                Inicio = movimentacaoInput.Inicio,
                Fim = movimentacaoInput.Fim,
                Cliente = container.NumeroDeSerie
            };

            await _context.Movimentacaos.AddAsync(movimentacao);
            await _context.SaveChangesAsync();

            return new OkObjectResult(movimentacao);
        }

        public Task<ActionResult<Movimentacao>> AlterarDataEHorarioMovimentacaoAsync(int id, DateTime inicio, DateTime fim)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Movimentacao>> AlterarTipoDeMovimentacaoAsync(int id, string tipo)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<List<Movimentacao>>> ReceberMovimentacaoPorClienteAsync(string cliente)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<List<Movimentacao>>> ReceberMovimentacaoPorContainerAsync(string numeroDeContainer)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Movimentacao>> ReceberMovimentacaoPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult> RemoverMovimentacaoAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
