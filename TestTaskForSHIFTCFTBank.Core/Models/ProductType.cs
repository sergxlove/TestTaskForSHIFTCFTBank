namespace TestTaskForSHIFTCFTBank.Core.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly Begin_date { get; set; }
        public DateOnly End_date { get; set; }
        public int Tarif_ref { get; set; }

        public override string ToString()
        {
            return $$"""
                {
                    {{Id}},
                    {{Name}},
                    {{Begin_date}},
                    {{End_date}},
                    {{Tarif_ref}}
                }
                """;
        }
    }
}
