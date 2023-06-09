﻿using Microsoft.EntityFrameworkCore;
using PortoApi.Models;
using PortoApi.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace PortoApi.Services.Implementacoes
{
    public class NumeroDeContainerService : INumeroDeContainerService
    {
        private readonly PortoDBContext _context;

        public NumeroDeContainerService(PortoDBContext context)
        {
            _context = context;
        }

        public async Task<bool> ChecarSeNumeroDeSerieExisteAsync(string numeroDeSerie)
        {
            bool numeroExiste = await _context.Containers.AnyAsync(c => c.NumeroDeSerie == numeroDeSerie);
            return numeroExiste;
        }

        public async Task<string> CriarNumeroDeSerieAsync()
        {
            string numeroDeSerie = "";
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numeros = "1234567890";
            Random random = new Random();

            for (int i = 0; i < 4; i++)
                numeroDeSerie = numeroDeSerie + alfabeto[random.Next(alfabeto.Length)];

            for (int i = 4; i < 11; i++)
                numeroDeSerie = numeroDeSerie + numeros[random.Next(numeros.Length)];

            var numeroExiste = await ChecarSeNumeroDeSerieExisteAsync(numeroDeSerie);

            if (numeroExiste == true)
                await CriarNumeroDeSerieAsync();

            return numeroDeSerie;
        }
    }
}
