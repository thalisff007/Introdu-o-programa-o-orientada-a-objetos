using System.ComponentModel.DataAnnotations;

namespace atividade
{
    public class ConsoleUtils
    {
        public static void WriteTitle(string text)
        {
            string formatedText = text;
            while (formatedText.Length < 120)
            {
                formatedText = " " + formatedText;
                if (formatedText.Length == 120) break;
                formatedText = formatedText + " ";
            }

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(formatedText);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static string textField(string fieldName, int fieldSize = 30)
        {
            Console.Write(fieldName);
            Console.Write(": ");
            (int left, int top) = Console.GetCursorPosition();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < fieldSize; i++) { Console.Write(" "); }
            Console.SetCursorPosition(left, top);
            string? result = Console.ReadLine();
            if (result == null) result = string.Empty;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n");
            return result;
        }

        public static int numericField(string fieldName, int fieldSize = 30, int startValue = 1900)
        {
            int value = startValue;
            (int left, int top) = Console.GetCursorPosition();

            while (true)
            {
                Console.SetCursorPosition((int)left, (int)top);
                Console.Write(fieldName);
                Console.Write(": < ");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                string stringValue = value.ToString();
                Console.Write(stringValue);
                for (int i = 0; i < fieldSize - stringValue.Length; i++) { Console.Write(" "); }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" >");
                var input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.UpArrow) value += 10;
                if (input.Key == ConsoleKey.RightArrow) value++;
                if (input.Key == ConsoleKey.LeftArrow) value--;
                if (input.Key == ConsoleKey.DownArrow) value -= 10;
                if (input.Key == ConsoleKey.Enter) break;
            }
            Console.Write("\n\n");
            return value;
        }

        public static float decimalField(string fieldName, int fieldSize = 30, float startValue = 0)
        {
            float value = startValue;
            (int left, int top) = Console.GetCursorPosition();

            while (true)
            {
                Console.SetCursorPosition((int)left, (int)top);
                Console.Write(fieldName);
                Console.Write(": < ");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                string stringValue = value.ToString("N");
                Console.Write(stringValue);
                for (int i = 0; i < fieldSize - stringValue.Length; i++) { Console.Write(" "); }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" >");
                var input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.UpArrow) value += 1;
                if (input.Key == ConsoleKey.RightArrow) value += 0.01f;
                if (input.Key == ConsoleKey.LeftArrow) value -= 0.01f;
                if (input.Key == ConsoleKey.DownArrow) value -= 1;
                if (input.Key == ConsoleKey.Enter) break;
            }
            Console.Write("\n\n");
            return value;
        }
    }
}