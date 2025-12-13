namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models
{
    public class RecordsEntity
    {
        public int ID { get; set; }
        public bool DT { get; set; }
        public decimal SUM { get; set; }
        public int ACC_REF { get; set; }
        public DateOnly OPER_DATE { get; set; }

        public virtual AccountsEntity? AccountsRef { get; set; }
    }
}
