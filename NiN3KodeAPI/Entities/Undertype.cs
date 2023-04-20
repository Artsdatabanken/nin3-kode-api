namespace NiN3KodeAPI.Entities
{
    public class Undertype : BaseEntity
    {
        public Hovedtypegruppe Hovedtypegruppe { get; set; }
        public Hovedtype Hovedtype { get; set; }
        public Grunntype Grunntype { get; set; }   
    }
}
