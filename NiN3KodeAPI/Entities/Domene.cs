﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiN3KodeAPI.Entities
{
    public class Domene
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Navn { get; set; } = string.Empty;
    }
}