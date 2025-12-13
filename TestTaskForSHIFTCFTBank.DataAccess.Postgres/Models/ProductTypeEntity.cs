namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models
{
    public class ProductTypeEntity
    {
        public int ID { get; set; }
        public string NAME { get; set; } = string.Empty;
        public DateOnly BEGIN_DATE { get; set; }
        public DateOnly END_DATE { get; set; }
        public int TARIF_REF { get; set; }

        public virtual TarifsEntity? TarifsRef { get; set; }
        public virtual List<ProductsEntity> ProductsRef { get; set; } = []; 
    }
}
