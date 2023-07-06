﻿using NiN3.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models.DTOs
{
    public class KartleggingsenhetDto
    {
        public string Kategori { get; set; } = "Kartleggingsenhet";
        public MaalestokkEnum Maalestokk { get; set; }
        public string Navn { get; set; }
        public string Kode { get; set; }
        public ICollection<GrunntypeDto> Grunntyper { get; set; } = new List<GrunntypeDto>();
    }
}
