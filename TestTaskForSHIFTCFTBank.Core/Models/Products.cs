namespace TestTaskForSHIFTCFTBank.Core.Models
{
    public class Products
    {
        public int Id { get; set; }
        public int Products_type_id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Client_ref { get; set; }
        public DateOnly Open_date { get; set; }
        public DateOnly Close_date { get; set; }

        public override string ToString()
        {
            return $$"""
                {
                    {{Id}},
                    {{Products_type_id}},
                    {{Name}},
                    {{Client_ref}},
                    {{Open_date}},
                    {{Close_date}}
                }
                """;
        }
    }
}
