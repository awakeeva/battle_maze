namespace battle_maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 20; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (j % 4 < 2)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write("    ");
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Write("    ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Write("    ");
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write("    ");
                    }
                    
                }
                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
