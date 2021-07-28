using System;

namespace Ordenacoes
{
    static class ConsoleUtils
    {
        public static void ShowTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(title);
            Console.ResetColor();
        }

        public static void ShowArray(int[] vetor, bool isResult = false)
        {
            if (isResult)
                Console.Write("RESULTADO: ");
            else
                Console.Write("VETOR: ");

            foreach (var n in vetor)
                Console.Write($"{n} ");

            Console.Write(Environment.NewLine);
        }
    }
}
