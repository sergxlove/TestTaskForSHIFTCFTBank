namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models
{
    public class ProductsEntity
    {
        public int ID { get; set; }
        public int PRODUCTS_TYPE_ID { get; set; }
        public string NAME { get; set; } = string.Empty;
        public int CLIENT_REF { get; set; }
        public DateOnly OPEN_DATE { get; set; }
        public DateOnly CLOSE_DATE { get; set; }
    }
}
