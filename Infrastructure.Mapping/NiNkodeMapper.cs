using NiN3.Core.Models.DTOs;
using NiN3.Core.Models;
using NiN3.Core.Models.Enums;
using System.Data;
using System.ComponentModel;
using Microsoft.Extensions.Configuration;

namespace NiN3.Infrastructure.Mapping
{

    /// <summary>
    /// Maps a Versjon object to a VersjonDto object.
    /// </summary>
    /// <param name="versjon">The Versjon object to be mapped.</param>
    /// <returns>A VersjonDto object with the mapped values.</returns>
    /// Usage: 
    /// NiNkodeMapper ninkodeMapper = NiNkodeMapper.Instance;
    /// ninkodeMapper.SetConfiguration(configuration);

    public sealed class NiNkodeMapper
    {
        private IConfiguration _configuration;
        private static readonly NiNkodeMapper instance = new NiNkodeMapper();
        private string _root_url;

        /// <summary>
        /// Gets the singleton instance of the NiNkodeMapper class.
        /// </summary>
        /// <returns>The singleton instance of the NiNkodeMapper class.</returns>
        public static NiNkodeMapper Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Sets the configuration for the application.
        /// </summary>
        /// <param name="configuration">The configuration to set.</param>
        public void SetConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
            _root_url = _configuration?["root_url"];
        }


        /// <summary>
        /// Maps a Versjon object to a VersjonDto object.
        /// </summary>
        /// <param name="versjon">The Versjon object to be mapped.</param>
        /// <returns>A VersjonDto object with the mapped data.</returns>
        public VersjonDto Map(Versjon versjon)
        {
            //Create a new VersjonDto object
            var versjonDto = new VersjonDto()
            {
                Navn = versjon.Navn,
            };
            //Loop through the list of Typer in the Versjon object
            //q: change the following line to use parallell loop        
            //a: 
            versjon.Typer.ToList().ForEach(t => versjonDto.Typer.Add(Map(t)));
            //Return the VersjonDto object
            return versjonDto;
        }


        /// <summary>
        /// Maps a NiN3.Core.Models.Type to a TypeDto
        /// </summary>
        /// <param name="type">The NiN3.Core.Models.Type to map</param>
        /// <returns>A TypeDto with the mapped values</returns>
        public TypeDto Map(NiN3.Core.Models.Type type)
        {
            var typedto = new TypeDto
            {
                Navn = $"{EnumUtil.ToDescription(type.Ecosystnivaa)} {EnumUtil.ToDescription(type.Typekategori)} {EnumUtil.ToDescriptionBlankIfNull(type.Typekategori2)}",
                Kategori = "Type",
                Kode = MapKode(type.Kode)
            };
            //type.Hovedtypegrupper.ToList().ForEach(h => typedto.Hovedtypegrupper.Add(Map(h)));
            Parallel.ForEach(type.Hovedtypegrupper.ToList(), g => typedto.Hovedtypegrupper.Add(Map(g)));
            return typedto;
        }


        /// <summary>
        /// Maps a Hovedtypegruppe object to a HovedtypegruppeDto object.
        /// </summary>
        /// <returns>
        /// A HovedtypegruppeDto object.
        /// </returns>
        public HovedtypegruppeDto Map(Hovedtypegruppe hovedtypegruppe)
        {
            var hovedtypegruppedto = new HovedtypegruppeDto()
            {
                Navn = hovedtypegruppe.Navn,
                Kategori = "Hovedtypegruppe",
                Kode = MapKode(hovedtypegruppe.Kode)
            };
            // This code uses the Parallel.ForEach method to loop through a list of Hovedtyper and add them to a Hovedtypegruppedto. The Map method is used to map the Hovedtyper to the Hovedtypegruppedto.
            Parallel.ForEach(hovedtypegruppe.Hovedtyper.ToList(), g => hovedtypegruppedto.Hovedtyper.Add(Map(g)));
            return hovedtypegruppedto;
        }

        /// <summary>
        /// Maps a Hovedtype object to a HovedtypeDto object.
        /// </summary>
        /// <param name="hovedtype">The Hovedtype object to be mapped.</param>
        /// <returns>A HovedtypeDto object with the mapped values.</returns>
        //This method maps a Hovedtype object to a HovedtypeDto object
        public HovedtypeDto Map(Hovedtype hovedtype)
        {
            var hovedtypedto = new HovedtypeDto()
            {
                Navn = hovedtype.Navn,
                Kategori = "Hovedtype",
                Kode = MapKode(hovedtype.Kode)
            };
            //q: rewrite next line to use parallel loop
            Parallel.ForEach(hovedtype.Grunntyper.ToList(), g => hovedtypedto.Grunntyper.Add(Map(g)));
            var hovedtype_kartleggingsenheter = hovedtype.Hovedtype_Kartleggingsenheter.ToList();

            //Parallel.ForEach(hovedtype_kartleggingsenheter.ToList(), g => hovedtypedto.Kartleggingsenheter.Add(Map(g.kartleggingsenhet)));
            /*
            foreach (var g in hovedtype_kartleggingsenheter)
            {
                if (g.Kartleggingsenhet != null)
                {
                    hovedtypedto.Kartleggingsenheter.Add(Map(g.Kartleggingsenhet));
                }
                else { 
                    Console.WriteLine($"Kartleggingsenhet is null for hovedtype {hovedtype.Navn} (, ht_kl-object: {g.Id})");
                }
            }*/
            Parallel.ForEach(hovedtype_kartleggingsenheter, g =>
            {
                if (g.Kartleggingsenhet != null)
                {
                    hovedtypedto.Kartleggingsenheter.Add(Map(g.Kartleggingsenhet));
                }
                else
                {
                    Console.WriteLine($"Kartleggingsenhet is null for hovedtype {hovedtype.Navn} (, ht_kl-object: {g.Id})");
                }
            });
            return hovedtypedto;
        }

        /// <summary>
        /// Maps a Grunntype object to a GrunntypeDto object.
        /// </summary>
        /// <param name="grunntype">The Grunntype object to be mapped.</param>
        /// <returns>A GrunntypeDto object with the mapped values.</returns>
        public GrunntypeDto Map(Grunntype grunntype)
        {
            var grunntypedto = new GrunntypeDto()
            {
                Navn = grunntype.Navn,
                Kategori = "Grunntype",
                Kode = MapKode(grunntype.Kode)
            };
            return grunntypedto;
        }

        /// <summary>
        /// Maps a Kartleggingsenhet object to a KartleggingsenhetDto object.
        /// </summary>
        /// <param name="kartleggingsenhet">The object to map</param>
        /// <returns>A newly created KartleggingsenhetDto object</returns>
        public KartleggingsenhetDto Map(Kartleggingsenhet kartleggingsenhet)
        {
            var kartleggingsenhetdto = new KartleggingsenhetDto()
            {
                Navn = kartleggingsenhet.Navn,
                Kategori = "Kartleggingsenhet",
                Kode = kartleggingsenhet.Kode,
                Maalestokk = $"{MaalestokkEnum.M005.ToString()}: {EnumUtil.ToDescription(MaalestokkEnum.M005)}"
            };
            Parallel.ForEach(kartleggingsenhet.Grunntyper.ToList(), g => kartleggingsenhetdto.Grunntyper.Add(Map(g)));
            return kartleggingsenhetdto;
        }


        /// <summary>
        /// Maps a code to a KodeDto object.
        /// </summary>
        /// <param name="kode">The code to be mapped.</param>
        /// <returns>A KodeDto object containing the code and its definition.</returns>
        public KodeDto MapKode(String kode)
        {
            //var _root_url = "https://nin-kode-api.artsdatabanken.no/v3.0";
            var kodeDto = new KodeDto()
            {
                Id = kode,
                Definisjon = _root_url + "/typer/hentkode/" + kode,
            };
            return kodeDto;
        }
    }
}
