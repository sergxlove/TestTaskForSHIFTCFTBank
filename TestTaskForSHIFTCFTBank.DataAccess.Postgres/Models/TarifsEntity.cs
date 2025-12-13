namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models
{
    public class TarifsEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Cost { get; set; }

        public virtual List<ProductTypeEntity> ProductTypesRef { get; set; } = [];
    }
}
