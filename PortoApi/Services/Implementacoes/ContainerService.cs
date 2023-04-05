using Microsoft.AspNetCore.Mvc;
using PortoApi.DTOs;
using PortoApi.Models;
using PortoApi.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortoApi.Services.Implementacoes
{
    public class ContainerService : IContainerService
    {
        private readonly PortoDBContext _context;

        public ContainerService(PortoDBContext context)
        {
            _context = context;
        }

        public Task<ActionResult<Container>> AdicionarContainerAsync(ContainerDto containerInput)
        {
            throw new System.NotImplementedException();
        }

        public Task<ActionResult<Container>> AlterarContainerAsync(string numeroDeSerie, string status, string tipo, string cliente)
        {
            throw new System.NotImplementedException();
        }

        public Task<ActionResult<List<Container>>> ReceberContainerDeClienteAsync(string cliente)
        {
            throw new System.NotImplementedException();
        }

        public Task<ActionResult<Container>> ReceberContainerPorNumeroDeSerieAsync(string numeroDeSerie)
        {
            throw new System.NotImplementedException();
        }

        public Task<ActionResult> RemoverContainerAsync(string numeroDeSerie)
        {
            throw new System.NotImplementedException();
        }
    }
}
