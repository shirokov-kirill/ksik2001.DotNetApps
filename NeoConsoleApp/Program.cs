namespace NeoConsoleApp
{
    internal class Program
    {

        public static void PrepareConsole()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        public static void ClearConsole()
        {
            Console.Clear();
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
        }

        public static void PrintToConsole(string message)
        {
            Console.WriteLine(message);
            // wait for user to read a message
            Thread.Sleep(2000);
        }

        static void Main(string[] args)
        {
            PrepareConsole();

            PrintToConsole("Wake up, Neo...");
            ClearConsole();

            PrintToConsole("The matrix has you...");
            ClearConsole();

            PrintToConsole("Follow the white rabbit.");
            ClearConsole();

            PrintToConsole("Knock, knock, Neo.");
            ClearConsole();
        }
    }
}
