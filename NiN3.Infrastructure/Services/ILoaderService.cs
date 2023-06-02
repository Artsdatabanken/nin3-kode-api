//using Microsoft.AspNetCore.Mvc;
using NiN3.Core.Models;

namespace NiN3.Infrastructure.Services
{
    public interface ILoaderService
    {
        //Task<IEnumerable<Domene>> HentDomenerAsync();
        public IEnumerable<Domene> HentDomener();

        //bool OpprettInitDbAsync();
        bool OpprettInitDb();
        void DoMigrations();

        List<string> Tabeller();

        string Tabelldata(string tablename);

        //void Startup();
    }
}
