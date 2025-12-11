namespace TestTaskForSHIFTCFTBank.Core.Models
{
    public class ProductType
    {
        public int ID { get; set; }
        public string NAME { get; set; } = string.Empty;
        public DateOnly BEGIN_DATE { get; set; }
        public DateOnly END_DATE { get; set; }
        public int TARIF_REF { get; set; }
    }
}
