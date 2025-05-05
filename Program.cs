namespace battle_maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int sizeHorizontal = 13;
            int sizeVertical = 13;

            int cellHorizontal = 4;
            int cellVertical = 2;

            for (int j = 0; j < sizeVertical; j++)
            {
                for (int i = 0; i < sizeHorizontal; i++)
                {
                    if ((i + j) % 2 == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }

                    for (int left = 0; left < cellHorizontal; left++)
                    {
                        for (int top = 0; top < cellVertical; top++)
                        {
                            Console.SetCursorPosition(
                                i * cellHorizontal + left,
                                j * cellVertical + top);
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("╔╛╘╗    ╔══╗");
            Console.WriteLine("╚══╝    ╚╕╒╝");
            Console.WriteLine("");
            Console.WriteLine("╔═╗_    _╔═╗");
            Console.WriteLine("╚═╝‾    ‾╚═╝");
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("▓▓▓▓");
            Console.WriteLine("▓▓▓▓");
            Console.WriteLine("▒▒▒▒");
            Console.WriteLine("▒▒▒▒");
            Console.WriteLine("░░░░");
            Console.WriteLine("░░░░");
            Console.WriteLine("////");
            Console.WriteLine("////");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
