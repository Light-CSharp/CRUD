namespace CRUD.Code_helper
{
    public static class Validator
    {
        public static int GetInt()
        {
            bool isCorrect;
            int number;

            do
            {
                isCorrect = int.TryParse(Console.ReadLine(), out number);
                if (!isCorrect)
                {
                    MessageAssistant.RedMessage("Неверный формат! Попробуйте ещё раз!");
                }
            } while (!isCorrect);

            return number;
        }

        public static int GetIntInRange(int minimum, int maximum)
        {
            bool isCorrect;
            int number;

            do
            {
                number = GetInt();

                isCorrect = number >= minimum && number <= maximum;
                if (!isCorrect)
                {
                    MessageAssistant.RedMessage($"Неверный формат! Введите число ещё раз, входящее в диапазон: {minimum}-{maximum}.");
                }
            } while (!isCorrect);

            return number;
        }

        public static string GetString()
        {
            bool isCorrect;
            string line;

            do
            {
                line = Console.ReadLine()!.Trim();

                isCorrect = string.IsNullOrEmpty(line);
                if (isCorrect)
                {
                    MessageAssistant.RedMessage("Неверный формат! Попробуйте ещё раз: ");
                }
            } while (isCorrect);

            return line;
        }
    }
}