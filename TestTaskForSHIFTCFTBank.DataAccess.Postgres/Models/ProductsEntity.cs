namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models
{
    public class ProductsEntity
    {
        public int Id { get; set; }
        public int Products_type_id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Client_ref { get; set; }
        public DateOnly Open_date { get; set; }
        public DateOnly? Close_date { get; set; }

        public virtual ProductTypeEntity? ProductsTypeRef { get; set; }
        public virtual ClientsEntity? ClientsRef { get; set; }
        public virtual List<AccountsEntity> AccountsRef { get; set; } = [];

    }
}
