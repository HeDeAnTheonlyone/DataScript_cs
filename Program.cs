using Compiler;
using Diagnostics;

namespace DataScript;



internal class Program
{
    static string? projPath;



    private static void Main()
    {
        var status = new Status();
        var parser = new Parser(status);

        while (true)
        {
            Console.Write("Input your projects filepath: ");
            Console.WriteLine();

            projPath = Console.ReadLine();
            if (string.IsNullOrEmpty(projPath) || !Directory.Exists(projPath))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Eneter a valid project path!");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }

            parser.Parse();
        }
    }
}