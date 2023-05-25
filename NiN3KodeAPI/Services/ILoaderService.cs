﻿using Microsoft.AspNetCore.Mvc;

namespace NiN3KodeAPI.Services
{
    public interface ILoaderService
    {
        Task<IEnumerable<Domene>> HentDomenerAsync();

        bool OpprettInitDbAsync();
        void DoMigrations();

        List<string> Tabeller();

        string Tabelldata(string tablename);

        //void Startup();
    }
}