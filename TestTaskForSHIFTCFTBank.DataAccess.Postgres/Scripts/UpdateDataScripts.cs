using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Scripts
{
    public class UpdateDataScripts
    {
        public static string ScriptTaskSixPart1()
        {
            return """
                SELECT accounts.id,
                    accounts.saldo,
                    COALESCE(
                        SUM(
                            CASE
                            WHEN records.dt = 1
                            THEN records.sum * (-1)
                            ELSE records.sum
                            END
                        ), 0
                    ) as current
                FROM accounts
                JOIN records ON accounts.id = records.acc_ref
                GROUP BY accounts.id, accounts.saldo;
                """;
        }

        public static string ScriptTaskSixPart2(string newSaldo, string id)
        {
            return $"""
                UPDATE accounts
                SET accounts.saldo = {newSaldo}
                WHERE accounts.id = {id};
                """;
        }

        public static string ScriptTaskEightPart1()
        {
            return """
                SELECT products.id
                FROM products
                JOIN accounts ON products.id = accounts.product_ref
                JOIN records ON accounts.id = records.acc_ref
                WHERE accounts.saldo = 0 
                AND products.product_type_id = 1
                AND products.close_date IS NULL
                GROUP BY products.id
                HAVING
                SUM(CASE 
                        WHEN r.dt = 1 
                        THEN r.sum 
                        ELSE 0 
                    END) =
                SUM(CASE 
                        WHEN r.dt = 0 
                        THEN r.sum 
                        ELSE 0 
                    END);
                """;
        }

        public static string ScriptTaskEightPart2(string date, string id)
        {
            return $"""
                UPDATE products
                SET products.close_date = {date}
                WHERE products.id = {id};
                """;
        }

        public static string ScriptTaskNinePart1()
        {
            return """
                SELECT clients.id,
                COUNT(accounts.id) as count_acc
                FROM clients
                JOIN accounts ON clients.id = accounts.client_ref
                JOIN products ON accounts.product_ref = products.id
                WHERE products.product_type_id = 3
                AND accounts.saldo > 0
                GROUP BY clients.id
                HAVING count_acc > 20;
                """;
        }

        public static string ScriptTaskNinePart2(string id)
        {
            return $"""
                SELECT accounts.id,
                accounts.saldo
                FROM accounts
                WHERE accounts.client_ref = {id}
                ORDER BY accounts.open_date 
                LIMIT 1;
                """;
        }

        public static string ScriptTaskNinePart3(string id)
        {
            return $"""
                SELECT accounts.id,
                accounts.saldo
                FROM accounts
                WHERE accounts.client_ref = {id}
                ORDER BY accounts.open_date 
                SKIP 1
                LIMIT 1;
                """;
        }

        public static string ScriptTaskNinePart4(string idAcc, string newSaldo)
        {
            return $"""
                UPDATE accounts
                SET accounts.saldo = {newSaldo}
                WHERE accounts.id = {idAcc};
                """;
        }

        public static string ScriptTaskNinePart5(string idAcc, string date)
        {
            return $"""
                UPDATE accounts
                SET accounts.saldo = 0
                accounts.close_date = {date}
                WHERE accounts.id = {idAcc};
                """;
        }

        public static string ScriptsTaskTenPart1()
        {
            return """
                ALTER TABLE products ADD COLUMN contract_sum NUMERIC(19,2);
                """;
        }

        public static string ScriptsTaskTenPart2()
        {
            return """
                UPDATE products 
                SET contract_sum = (
                    SELECT MIN(records.sum)
                    FROM accounts
                    JOIN records ON accounts.id = records.acc_ref
                    WHERE records.dt = 1 )
                WHERE products.product_type_id = 1;
                """;
        }

        public static string ScriptsTaskTenPart3() 
        {
            return """
                UPDATE products
                SET contract_sum = (
                    SELECT AVG(records.sum)
                    FROM accounts
                    JOIN records ON accounts.id = records.acc_ref
                    WHERE records.dt = 0 )
                WHERE products.product_type_id = 2 
                OR products.product_type_id = 3;
                """;
        }
    }
}
