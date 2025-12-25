namespace TestTaskForSHIFTCFTBank.Core.Models
{
    public class Accounts
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Saldo { get; set; }
        public int Client_ref { get; set; }
        public DateOnly Open_date { get; set; }
        public DateOnly Close_date { get; set; }
        public int Product_ref { get; set; }
        public string Acc_num { get; set; } = string.Empty;

        public override string ToString()
        {
            return $$"""
                {
                    {{Id}},
                    {{Name}},
                    {{Saldo}},
                    {{Client_ref}},
                    {{Open_date}},
                    {{Close_date}},
                    {{Product_ref}},
                    {{Acc_num}}
                }
                """;
        }
    }
}
