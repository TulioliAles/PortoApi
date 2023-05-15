using Microsoft.AspNetCore.Mvc;
using PortoApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortoApi.Services.Interfaces
{
    public interface IRelatorioService
    {
        public Task<Dictionary<string, int>> ContarTodasMovimentacoesPorClienteAsync();
        public Task<Dictionary<string, int>> ContarTodasMovimentacoesPorTipoAsync();
        public Task<ActionResult<Relatorio>> GerarRelatorioFinalAsync();
    }
}
