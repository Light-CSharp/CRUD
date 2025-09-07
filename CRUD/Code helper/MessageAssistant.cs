namespace CRUD.Code_helper
{
    public static class MessageAssistant
    {
        /// <summary>
        /// Выводит сообщение зелёного цвета, нужен для обозначения успешности действия.
        /// </summary>
        /// <param name="message"></param>
        public static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Выводит сообщение красного цвета, нужен для обозначения неудачности действия.
        /// </summary>
        /// <param name="message"></param>
        public static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Выводит сообщение синего цвета, нужен для обозначения сведений.
        /// </summary>
        /// <param name="message"></param>
        public static void BlueMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}