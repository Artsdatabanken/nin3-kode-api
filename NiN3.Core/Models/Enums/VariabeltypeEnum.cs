using System.ComponentModel;

namespace NiN3.Core.Models.Enums
{ 
public enum VariabeltypeEnum
{
    [Description("enkel, ikke-ordnet faktorvariabel")]
    FE,
    [Description("kompleks, ikke-ordnet faktorvariabel")]
    FK,
    [Description("enkel gradient")]
    GE,
    [Description("kompleks gradient")]
    GK } 
}
