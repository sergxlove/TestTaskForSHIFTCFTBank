namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Scripts
{
    public class DeleteDataTableScripts
    {
        public static string DeleteTarifs()
        {
            return """
                DELETE FROM tarifs;
                """;
        }

        public static string DeleteProductType()
        {
            return """
                DELETE FROM productype;
                """;
        }

        public static string DeleteClients()
        {
            return """
                DELETE FROM clients;
                """;
        }

        public static string DeleteProducts()
        {
            return """
                DELETE FROM products;
                """;
        }

        public static string DeleteAccounts()
        {
            return """
                DELETE FROM accounts;
                """;
        }

        public static string DeleteRecords()
        {
            return """
                DELETE FROM records;
                """;
        }

        public static string DeleteAll()
        {
            return DeleteRecords() + "\n" +
                DeleteAccounts() + "\n" +
                DeleteProducts() + "\n" +
                DeleteClients() + "\n" +
                DeleteProductType() + "\n" +
                DeleteTarifs();
        }
    }
}
