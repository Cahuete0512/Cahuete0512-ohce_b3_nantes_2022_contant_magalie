using OHCE;

namespace OHCE.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Veuillez rentrer un mot pour en obtenir l\n'inverse : ");
            System.Console.WriteLine(Mirror.returnMirror(System.Console.ReadLine() ?? String.Empty));
            
        }
    }
}

