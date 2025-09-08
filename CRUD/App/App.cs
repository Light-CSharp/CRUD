using CRUD.Code_helper;
using CRUD.Logic_of_records;

namespace CRUD.App
{
    public enum Actions : byte
    {
        CreateRecord = 1,
        ShowRecords,
        UpdateRecord,
        DeleteRecord
    }

    public class App
    {
        static Actions ShowMenu()
        {
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1. Сделать заметку.");
            Console.WriteLine("2. Посмотреть заметки.");
            Console.WriteLine("3. Обновить заметку.");
            Console.WriteLine("4. Удалить заметку.");

            int choice = Validator.GetIntInRange(1, 4);
            Console.Clear();

            return (Actions)choice;
        }

        static void Run()
        {
            while (true)
            {
                switch (ShowMenu())
                {
                    case Actions.CreateRecord:
                        RecordManager.CreateRecord();

                        MessageAssistant.GreenMessage("Запись создана!");
                        Console.WriteLine();
                        break;

                    case Actions.ShowRecords:
                        RecordManager.ShowRecords();

                        Console.WriteLine();
                        break;

                    case Actions.UpdateRecord:
                        RecordManager.UpdateRecord();

                        MessageAssistant.GreenMessage("Запись была изменена!");
                        Console.WriteLine();
                        break;

                    case Actions.DeleteRecord:
                        RecordManager.DeleteRecord();

                        MessageAssistant.GreenMessage("Запись была удалена!");
                        Console.WriteLine();
                        break;
                }
            }
        }

        static void Main() => Run();
    }
}