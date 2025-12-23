namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Scripts
{
    public class SelectDataScripts
    {
        public static string ScriptTaskThree()
        {
            return """
                SELECT * 
                FROM accounts
                JOIN products ON accounts.product_ref = products.id
                WHERE products.product_type_id = 2 
                AND products.close_date IS NULL 
                AND accounts.close_date IS NULL
                AND accounts.client_ref IN (
                    SELECT accounts.client_ref
                    FROM accounts
                    GROUP BY accounts.client_ref
                    HAVING COUNT(*) > 1
                );
                """;
        }
    }
}
