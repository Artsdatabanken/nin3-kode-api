﻿using NiN3.Core.Models.DTOs;
using NiN3.Core.Models;
using NiN3.Core.Models.Enums;
using System.Data;
using System.ComponentModel;
using Microsoft.Extensions.Configuration;
using NiN3.Core.Models.DTOs.type;
using NiN3.Core.Models.DTOs.variabel;
using System.Collections.Concurrent;
using System;

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
            // Create a ConcurrentBag for mapped Typer
            /*if (versjon.Typer != null && versjon.Typer.Any())
            {
                var typerBag = new ConcurrentBag<TypeDto>();
                Parallel.ForEach(versjon.Typer, t => typerBag.Add(Map(t)));
                versjonDto.Typer = typerBag.ToList().OrderBy(t => t.Kode.Id).ToList();
            }*/
            if (versjon.Typer != null && versjon.Typer.Any())
            {
                var typerList = versjon.Typer.AsParallel()
                    .Select(t => Map(t))
                    .OrderBy(t => t.Kode.Id)
                    .ToList();
                versjonDto.Typer = typerList;
            }



            // Create a ConcurrentBag for mapped Variabler
            if (versjon.Variabler != null && versjon.Variabler.Any()) { 
                var variablerBag = new ConcurrentBag<VariabelDto>();
                Parallel.ForEach(versjon.Variabler, v => variablerBag.Add(Map(v)));
                versjonDto.Variabler = variablerBag.ToList().OrderBy(v => v.Kode.Id).ToList();
            }

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
            var _typekategori2 = type.Typekategori2 !=null ? $"{type.Typekategori2.ToString()}: {EnumUtil.ToDescriptionBlankIfNull(type.Typekategori2)}" : null;
            var typedto = new TypeDto
            {
                //Navn = $"{EnumUtil.ToDescription(type.Ecosystnivaa)} {EnumUtil.ToDescription(type.Typekategori)} {EnumUtil.ToDescriptionBlankIfNull(type.Typekategori2)}",
                Navn = $"{EnumUtil.ToDescriptionBlankIfNull(type.Typekategori2)}",
                Kategori = "Type",
                //Ecosystnivaa = $"{type.Ecosystnivaa.ToString()}: {EnumUtil.ToDescription(type.Ecosystnivaa)}",
                EcosystnivaaEnum = type.Ecosystnivaa,
                EcosystnivaaNavn = EnumUtil.ToDescription(type.Ecosystnivaa),
                TypekategoriEnum = type.Typekategori,
                TypekategoriNavn = EnumUtil.ToDescription(type.Typekategori),
                Typekategori2Enum = type.Typekategori2,
                Typekategori2Navn = EnumUtil.ToDescriptionBlankIfNull(type.Typekategori2),
                Kode = MapKode(type.Kode, type.Langkode),
                Langkode = type.Langkode
            };
            //type.Hovedtypegrupper.ToList().ForEach(h => typedto.Hovedtypegrupper.Add(Map(h)));
            var hovedtypegrupperBag = new ConcurrentBag<HovedtypegruppeDto>();
            Parallel.ForEach(type.Hovedtypegrupper.ToList(), g => hovedtypegrupperBag.Add(Map(g)));
            typedto.Hovedtypegrupper = hovedtypegrupperBag.ToList();
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
                //Typekategori3 = hovedtypegruppe.Typekategori3 != null ? $"{hovedtypegruppe.Typekategori3.ToString()}: {EnumUtil.ToDescription(hovedtypegruppe.Typekategori3)}" : "",
                Typekategori3Enum = (Typekategori3Enum)hovedtypegruppe.Typekategori3,
                Typekategori3Navn = EnumUtil.ToDescription(hovedtypegruppe.Typekategori3),
                Kode = MapKode(hovedtypegruppe.Kode, hovedtypegruppe.Langkode)
            };
            // This code uses the Parallel.ForEach method to loop through a list of Hovedtyper and add them to a Hovedtypegruppedto. The Map method is used to map the Hovedtyper to the Hovedtypegruppedto.
            //Parallel.ForEach(hovedtypegruppe.Hovedtyper.ToList(), g => hovedtypegruppedto.Hovedtyper.Add(Map(g)));
            var hovedtyperBag = new ConcurrentBag<HovedtypeDto>();
            Parallel.ForEach(hovedtypegruppe.Hovedtyper.ToList(), g => hovedtyperBag.Add(Map(g)));
            hovedtypegruppedto.Hovedtyper = hovedtyperBag.ToList();
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
                Kode = MapKode(hovedtype.Kode, hovedtype.Langkode),
                //Prosedyrekategori = $"{hovedtype.Prosedyrekategori.ToString()}: {EnumUtil.ToDescription(hovedtype.Prosedyrekategori)}",
                ProsedyrekategoriEnum = hovedtype.Prosedyrekategori,
                ProsedyrekategoriNavn = EnumUtil.ToDescription(hovedtype.Prosedyrekategori),
            };
            var grunntyperBag = new ConcurrentBag<GrunntypeDto>();
            Parallel.ForEach(hovedtype.Grunntyper.ToList(), g => grunntyperBag.Add(Map(g)));
            hovedtypedto.Grunntyper = grunntyperBag.ToList();
            var kartleggingsenheterBag = new ConcurrentBag<KartleggingsenhetDto>();
            Parallel.ForEach(hovedtype.Hovedtype_Kartleggingsenheter.ToList(), g =>
            {
                if (g.Kartleggingsenhet != null)
                {
                    kartleggingsenheterBag.Add(Map(g.Kartleggingsenhet));
                }
                else
                {
                    Console.WriteLine($"Kartleggingsenhet is null for hovedtype {hovedtype.Navn} (, ht_kl-object: {g.Id})");
                }
            });
            hovedtypedto.Kartleggingsenheter = kartleggingsenheterBag.ToList();
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
                Kode = MapKode(grunntype.Kode, grunntype.Langkode)
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
                Kortkode = kartleggingsenhet.Kortkode,
                //Maalestokk = $"{kartleggingsenhet.Maalestokk.ToString()}: {EnumUtil.ToDescription(kartleggingsenhet.Maalestokk)}"
                MaalestokkEnum = kartleggingsenhet.Maalestokk,
                MaalestokkNavn = EnumUtil.ToDescription(kartleggingsenhet.Maalestokk)
            };
            var grunntyperBag = new ConcurrentBag<GrunntypeDto>();
            Parallel.ForEach(kartleggingsenhet.Grunntyper.ToList(), g => grunntyperBag.Add(Map(g)));
            kartleggingsenhetdto.Grunntyper = grunntyperBag.ToList();

            return kartleggingsenhetdto;
        }


        /// <summary>
        /// Maps a code to a KodeDto object.
        /// </summary>
        /// <param name="kode">The code to be mapped.</param>
        /// <returns>A KodeDto object containing the code and its definition.</returns>
        public KodeDto MapKode(String kode, String? langkode=null, bool fortyper = true)
        {
            var typeOrVar = fortyper? "typer": "variabler";
            //var _root_url = "https://nin-kode-api.artsdatabanken.no/v3.0";
            var kodeDto = new KodeDto()
            {
                Id = kode,
                Definisjon = _root_url + $"/{typeOrVar}/hentkode/" + kode,
            };
            if(langkode != null)
            {
                kodeDto.Langkode = langkode;
            }
            return kodeDto;
        }

        /// <summary>
        /// Maps a <paramref name="variabel"/> to a <see cref="VariabelDto"/> object.
        /// </summary>
        /// <param name="variabel">The <see cref="Variabel"/> object to map.</param>
        /// <returns>A new <see cref="VariabelDto"/> object that represents the mapped <paramref name="variabel"/>.</returns>
        public VariabelDto Map(Variabel variabel)
        {
            var variabelDto = new VariabelDto()
            {
                Kode = MapKode(variabel.Kode, null, false),
                Navn = variabel.Navn,
                Kategori = "Variabel",
                Ecosystnivaa = $"{variabel.Ecosystnivaa.ToString()}: {EnumUtil.ToDescription(variabel.Ecosystnivaa)}",
                Variabelkategori = $"{variabel.Variabelkategori.ToString()}: {EnumUtil.ToDescription(variabel.Variabelkategori)}"
            };

            var variabelnavnBag = new ConcurrentBag<VariabelnavnDto>();
            Parallel.ForEach(variabel.Variabelnavn.ToList(), vn => variabelnavnBag.Add(Map(vn)));
            variabelDto.Variabelnavn = variabelnavnBag.ToList();

            return variabelDto;
        }


        // <summary>
        /// Maps a Variabelnavn object to a VariabelnavnDto object.
        /// </summary>
        /// <param name="variabelnavn">The Variabelnavn object to map.</param>
        /// <returns>A VariabelnavnDto object mapping the values of the Variabelnavn parameter.</returns>
        public VariabelnavnDto Map(Variabelnavn variabelnavn)
        {
            var variabelnavnDto = new VariabelnavnDto()
            {
                Navn = variabelnavn.Navn,
                Kode = MapKode(variabelnavn.Kode, variabelnavn.Langkode, false),
                Variabelkategori2 = $"{variabelnavn.Variabelkategori2.ToString()}: {EnumUtil.ToDescription(variabelnavn.Variabelkategori2)}",
                Variabeltype = $"{variabelnavn.Variabeltype.ToString()}: {EnumUtil.ToDescription(variabelnavn.Variabeltype)}",
                Variabelgruppe = $"{variabelnavn.Variabelgruppe.ToString()}: {EnumUtil.ToDescription(variabelnavn.Variabelgruppe)}",
            };
            return variabelnavnDto;
        }
    }
}
