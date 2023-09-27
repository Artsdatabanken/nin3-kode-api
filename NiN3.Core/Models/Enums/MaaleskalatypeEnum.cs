using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models.Enums
{
    public enum MaaleskalatypeEnum
    {
        [Description("binær")]
        B,
        [Description("telleskala, observert antall")]
        D,
        [Description("telleskala, observert antall")]
        D0,
        [Description("telleskala, observert antall")]
        D1a,
        [Description("telleskala, observert antall")]
        D1b,
        [Description("kontinuerlig, observert verdi")]
        K,
        [Description("generisk måleskala for andelsvariabel")]
        P,
        [Description("generisk måleskala for andelsvariabel")]
        P6a,
        [Description("generisk måleskala for andelsvariabel")]
        P6c,
        [Description("Prosentskala")]
        P9a,
        [Description("generisk måleskala for andelsvariabel, der n angir trinn om m angir variant")]
        Pnm,
        [Description("Variabelspesifikk, ikke-ordnet faktorverdi")]
        SI,
        [Description("Variabelspesifikk, ordnet faktorverdi")]
        SO,
        [Description("tetthetsskala, 2-logaritmisk")]
        T,
        [Description("tetthetsskala, 2-logaritmisk")]
        T0,
        [Description("tetthetsskala, 2-logaritmisk")]
        T1a,
        [Description("tetthetsskala, 2-logaritmisk")]
        T1b,
        [Description("tetthetsskala, 2-logaritmisk")]
        T1c
    }
}
