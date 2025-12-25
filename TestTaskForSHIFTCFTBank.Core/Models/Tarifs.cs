namespace TestTaskForSHIFTCFTBank.Core.Models
{
    public class Tarifs
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Cost { get; set; }

        public override string ToString()
        {
            return $$"""
                    {{Id}},
                    {{Name}},
                    {{Cost}}
                """;
        }
    }
}
