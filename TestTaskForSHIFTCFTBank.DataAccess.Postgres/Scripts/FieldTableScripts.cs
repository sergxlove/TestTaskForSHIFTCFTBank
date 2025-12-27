namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Scripts
{
    public class FieldTableScripts
    {
        public static string FieldTarifs()
        {
            return """
                INSERT INTO tarifs ("id", "name", "cost") VALUES 
                (1, 'Тариф за выдачу кредита', 10),
                (2, 'Тариф за открытие счета', 10),
                (3, 'Тариф за обслуживание карты', 10);
                """;
        }

        public static string FieldProductType()
        {
            return """
                INSERT INTO productype ("id", "name", "begin_date", "end_date", "tarif_ref") VALUES 
                (1, 'КРЕДИТ', '2018-01-01', NULL, 1),
                (2, 'ДЕПОЗИТ', '2018-01-01', NULL, 2),
                (3, 'КАРТА', '2018-01-01', NULL, 3);
                """;
        }

        public static string FieldClients()
        {
            return """
                INSERT INTO clients ("id", "name", "place_of_birth", "date_of_birth", "address", "passport") VALUES 
                (1, 'Сидоров Иван Петрович', 'Россия, Московская область, г. Пушкин', '2001-01-01', 'Россия, Московская область, г. Пушкин, ул. Грибоедова, д. 5', '2222 555555, выдан ОВД г. Пушкин, 10.01.2015'),
                (2, 'Иванов Петр Сидорович', 'Россия, Московская область, г. Клин', '2001-01-01', 'Россия, Московская область, г. Клин, ул. Мясникова, д. 3', '4444 666666, выдан ОВД г. Клин, 10.01.2015'),
                (3, 'Петров Сидор Иванович', 'Россия, Московская область, г. Балашиха', '2001-01-01', 'Россия, Московская область, г. Балашиха, ул. Пушкина, д. 7', '4444 666666, выдан ОВД г. Клин, 10.01.2015');
                """;
        }

        public static string FieldProducts()
        {
            return """
                INSERT INTO products ("id", "product_type_id", "name", "client_ref", "open_date", "close_date") VALUES 
                (1, 1, 'Кредитный договор с Сидоровым И.П.', 1, '2015-06-01', NULL),
                (2, 2, 'Депозитный договор с Сидоровым И.П.', 1, '2017-08-01', NULL),
                (3, 3, 'Карточный договор с Сидоровым И.П.', 1, '2017-08-01', NULL);
                """;
        }

        public static string FieldAccounts()
        {
            return """
                INSERT INTO accounts ("id", "name", "saldo", "client_ref", "open_date", "close_date", "product_ref", "acc_num") VALUES 
                (1, 'Кредитный счет для Сидорова И.П.', -2000, 1, '2015-06-01', NULL, 1, '45502810401020000022'),
                (2, 'Депозитный счет для Сидорова И.П.', 6000, 2, '2017-08-01', NULL, 2, '42301810400000000001'),
                (3, 'Карточный счет для Сидорова И.П.', 8000, 3, '2017-08-01', NULL, 3, '40817810700000000001');
                """;
        }

        public static string FieldRecords()
        {
            return """
                INSERT INTO records ("id", "dt", "sum", "acc_ref", "oper_date") VALUES 
                (1, 1, 5000, 1, '2015-06-01'),
                (2, 0, 1000, 1, '2015-07-01'),
                (3, 0, 2000, 1, '2015-08-01'),
                (4, 0, 3000, 1, '2015-09-01'),
                (5, 1, 5000, 1, '2015-10-01'),
                (6, 0, 3000, 1, '2015-10-01'),
                (7, 0, 10000, 2, '2017-08-01'),
                (8, 1, 1000, 2, '2017-08-05'),
                (9, 1, 2000, 2, '2017-09-21'),
                (10, 1, 5000, 2, '2017-10-24'),
                (11, 0, 6000, 2, '2017-11-26'),
                (12, 0, 120000, 3, '2017-09-08'),
                (13, 1, 1000, 3, '2017-10-05'),
                (14, 1, 2000, 3, '2017-10-21'),
                (15, 1, 5000, 3, '2017-10-24');
                """;
        }

        public static string FieldAll()
        {
            return FieldTarifs() + "\n" +
                FieldProductType() + "\n" +
                FieldClients() + "\n" +
                FieldProducts() + "\n" +
                FieldAccounts() + "\n" +
                FieldRecords();
        }
    }
}
