using Microsoft.AspNetCore.Mvc;
using PortoApi.DTOs;
using PortoApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortoApi.Services.Interfaces
{
    public interface IContainerService
    {
        public Task<ActionResult<Container>> AdicionarContainerAsync(ContainerDto containerInput);
        public Task<ActionResult<Container>> AlterarContainerAsync(string numeroDeSerie, string? status, string? categoria, string? cliente);
        public Task<ActionResult> RemoverContainerAsync(string numeroDeSerie);
        public Task<ActionResult<Container>> ReceberContainerPorNumeroDeSerieAsync(string numeroDeSerie);
        public Task<ActionResult<List<Container>>> ReceberContainerDeClienteAsync(string cliente);
    }
}
