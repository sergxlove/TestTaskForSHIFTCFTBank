namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models
{
    public class RecordsEntity
    {
        public int Id { get; set; }
        public bool Dt { get; set; }
        public decimal Sum { get; set; }
        public int Acc_ref { get; set; }
        public DateOnly Oper_date { get; set; }

        public virtual AccountsEntity? AccountsRef { get; set; }
    }
}
