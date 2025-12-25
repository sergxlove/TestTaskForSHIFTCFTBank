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
    }
}
