﻿//using Microsoft.AspNetCore.Mvc;
using NiN3.Core.Models;

namespace NiN3.Infrastructure.Services
{
    public interface ILoaderService
    {
        //Task<IEnumerable<Versjon>> HentDomenerAsync();
        public IEnumerable<Versjon> HentDomener();

        //bool OpprettInitDbAsync();
        bool OpprettInitDb();
        void DoMigrations();

        List<string> Tabeller();

        string Tabelldata(string tablename);

        //void Startup();
    }
}