using CRUD.Code_helper;

namespace CRUD.Logic_of_records
{
    public static class RecordManager
    {
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
    }
}