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

        public static string ScriptTaskFour()
        {
            return """
                SELECT *
                FROM accounts
                JOIN products ON accounts.product_ref = products.id
                JOIN records ON accounts.id = records.acc_ref
                WHERE (products.product_type_id = 2 
                OR products.product_type_id = 3)
                AND records.dt = 0
                AND records.oper_date = '2015-06-01'
                """;
        }

        public static string ScriptTaskFive()
        {
            return """
                SELECT * 
                FROM clients
                JOIN products ON clients.id = products.client_ref
                JOIN accounts ON clients.id = accounts.client_ref
                JOIN records ON accounts.id = records.acc_ref
                WHERE products.product_type_id = 1
                GROUP BY clients.id, clients.name, clients.place_of_birth, 
                    clients.date_of_birth, clients.address, clients.passport
                HAVING 
                SUM(
                    CASE 
                        WHEN records.dt = 1 
                        THEN records.sum
                        ELSE 0
                    END) > 
                SUM(
                    CASE 
                        WHEN records.dt = 0 
                        THEN records.sum
                        ELSE 0
                    END);
                """;
        }
    }
}
