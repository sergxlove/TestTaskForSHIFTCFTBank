namespace TestTaskForSHIFTCFTBank.Core.Models
{
    public class Records
    {
        public int ID { get; set; }
        public bool DT { get; set; }
        public decimal SUM { get; set; }
        public string ACC_REF { get; set; } = string.Empty;
        public DateOnly OPER_DATE { get; set; }
    }
}
