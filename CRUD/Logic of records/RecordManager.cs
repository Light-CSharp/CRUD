using CRUD.Code_helper;

namespace CRUD.Logic_of_records
{
    public static class RecordManager
    {
        private enum UpdateOption
        {
            Title = 1,
            Description,
            Full
        }

        private static List<Record> records = [];

        private static int GetRecordIndex()
        {
            Console.WriteLine("Выберите номер записи: ");
            for (int i = 0; i < records.Count; i++)
            {
                MessageAssistant.BlueMessage($"Номер: {i + 1}. Запись: {records[i].GetRecord}");
            }

            // Из вводимого номера вычитаем 1, чтобы получить индекс записи.
            int recordIndex = Validator.GetIntInRange(1, records.Count + 1) - 1;
            return recordIndex;
        }

        private static bool HasRecords()
        {
            if (records.Count == 0)
            {
                MessageAssistant.RedMessage("Коллекция записей пуста!");
                return false;
            }

            return true;
        }

        private static UpdateOption ShowUpdateRecordMenu()
        {
            Console.WriteLine("Выберите, что хотите изменить: ");
            Console.WriteLine("1. Оглавление записи.");
            Console.WriteLine("2. Описание записи.");
            Console.WriteLine("3. Полностью перезаписать запись.");

            return (UpdateOption)Validator.GetIntInRange(1, 3);
        }

        private static void UpdateTitle(int recordIndex, Record record)
        {
            Console.WriteLine("Введите новое наименование записи: ");
            string newTitle = Validator.GetString();

            records[recordIndex] = record with { Title = newTitle };
        }

        private static void UpdateDescription(int recordIndex, Record record)
        {
            Console.WriteLine("Введите новое описание записи: ");
            string newDescription = Validator.GetString();

            records[recordIndex] = record with { Description = newDescription };
        }

        private static void UpdateFull(int recordIndex, Record record)
        {
            Console.WriteLine("Введите новое наименование записи: ");
            string newTitle = Validator.GetString();

            Console.WriteLine("Введите новое описание записи: ");
            string newDescription = Validator.GetString();

            records[recordIndex] = record with { Title = newTitle, Description = newDescription };
        }

        public static void CreateRecord()
        {
            Console.Write("Введите наименование записи: ");
            string title = Validator.GetString();

            Console.Write("Введите описание записи: ");
            string description = Validator.GetString();

            records.Add(new Record(title, description));
        }

        public static void ShowRecords()
        {
            if (!HasRecords())
            {
                return;
            }

            MessageAssistant.BlueMessage("Записи в коллекции: ");
            for (int i = 0; i < records.Count; i++)
            {
                MessageAssistant.BlueMessage($"Номер {i + 1}. {records[i].GetRecord}");
            }
        }

        public static void UpdateRecord()
        {
            if (!HasRecords())
            {
                return;
            }

            int recordIndex = GetRecordIndex();
            Record record = records[recordIndex];

            switch (ShowUpdateRecordMenu())
            {
                case UpdateOption.Title:
                    UpdateTitle(recordIndex, record);
                    break;

                case UpdateOption.Description:
                    UpdateDescription(recordIndex, record);
                    break;

                case UpdateOption.Full:
                    UpdateFull(recordIndex, record);
                    break;
            }
        }

        public static void DeleteRecord()
        {
            if (!HasRecords())
            {
                return;
            }

            int recordIndex = GetRecordIndex();
            records.RemoveAt(recordIndex);
        }
    }
}