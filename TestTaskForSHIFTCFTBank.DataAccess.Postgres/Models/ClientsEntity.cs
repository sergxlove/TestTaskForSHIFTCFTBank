namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models
{
    public class ClientsEntity
    {
        public int ID { get; set; }
        public string NAME { get; set; } = string.Empty;
        public string PLACE_OF_BIRTH { get; set; } = string.Empty;
        public DateOnly DATE_OF_BIRTH { get; set; }
        public string ADDRESS { get; set; } = string.Empty;
        public string PASSSPORT { get; set; } = string.Empty;

        public virtual List<ProductsEntity> ProductsRef { get; set; } = [];
        public virtual List<AccountsEntity> AccountsRef { get; set; } = [];
    }
}
