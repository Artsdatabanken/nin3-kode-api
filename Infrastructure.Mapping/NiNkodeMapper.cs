﻿using NiN3.Core.Models.DTOs;
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
            type.Hovedtypegrupper.ToList().ForEach(h => typedto.Hovedtypegrupper.Add(Map(h)));
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
            hovedtypegruppe.Hovedtyper.ToList().ForEach(h => hovedtypegruppedto.Hovedtyper.Add(Map(h)));
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
            hovedtype.Grunntyper.ToList().ForEach(g => hovedtypedto.Grunntyper.Add(Map(g)));
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
