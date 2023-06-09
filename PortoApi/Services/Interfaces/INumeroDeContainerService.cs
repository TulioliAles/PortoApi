﻿using System.Threading.Tasks;

namespace PortoApi.Services.Interfaces
{
    public interface  INumeroDeContainerService
    {
        public Task<bool> ChecarSeNumeroDeSerieExisteAsync(string numeroDeSerie);

        public Task<string> CriarNumeroDeSerieAsync();
    }
}
