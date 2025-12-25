namespace TestTaskForSHIFTCFTBank.Core.Models
{
    public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Place_of_birth { get; set; } = string.Empty;
        public DateOnly Date_of_birth { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Passport { get; set; } = string.Empty;

        public override string ToString()
        {
            return $$"""
                {
                    {{Id}},
                    {{Name}},
                    {{Place_of_birth}},
                    {{Date_of_birth}},
                    {{Address}},
                    {{Passport}}
                }
                """;
        }
    }
}
