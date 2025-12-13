namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models
{
    public class TarifsEntity
    {
        public int ID { get; set; }
        public string NAME { get; set; } = string.Empty;
        public decimal COST { get; set; }

        public virtual List<ProductTypeEntity> ProductTypesRef { get; set; } = [];
    }
}
