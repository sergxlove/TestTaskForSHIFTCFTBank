namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models
{
    public class ProductTypeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly Begin_date { get; set; }
        public DateOnly End_date { get; set; }
        public int Tarif_ref { get; set; }

        public virtual TarifsEntity? TarifsRef { get; set; }
        public virtual List<ProductsEntity> ProductsRef { get; set; } = []; 
    }
}
