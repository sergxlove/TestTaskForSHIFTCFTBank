namespace TestTaskForSHIFTCFTBank.Core.Models
{
    public class Accounts
    {
        public int ID { get; set; }
        public string NAME { get; set; } = string.Empty;
        public decimal SALDO { get; set; }
        public int CLIENT_REF { get; set; }
        public DateOnly OPEN_DATE { get; set; }
        public DateOnly CLOSE_DATE { get; set; }
        public int PRODUCT_REF { get; set; }
        public string ACC_NUM { get; set; } = string.Empty;
    }
}
