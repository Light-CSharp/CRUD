namespace CRUD.Logic_of_records
{
    public record Record(string Title, string Description)
    {
        public string GetRecord => $"Наименование записи: {Title}.\nЕё описание: {Description}.";
    }
}