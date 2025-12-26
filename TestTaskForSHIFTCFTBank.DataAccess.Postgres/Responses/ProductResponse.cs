namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Responses
{
    public class ProductResponse
    {
        public string Name { get; set; } = string.Empty;
        public decimal Sum_credit { get; set; }
        public int Count_operation { get; set; }

        public override string ToString()
        {
            return $$"""
                {
                    {{Name}},
                    {{Sum_credit}},
                    {{Count_operation}}
                }
                """;
        }
    }
}
