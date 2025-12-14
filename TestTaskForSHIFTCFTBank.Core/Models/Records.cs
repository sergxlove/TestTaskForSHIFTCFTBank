namespace TestTaskForSHIFTCFTBank.Core.Models
{
    public class Records
    {
        public int Id { get; set; }
        public int Dt { get; set; }
        public decimal Sum { get; set; }
        public int Acc_ref { get; set; }
        public DateOnly Oper_date { get; set; }
    }
}
