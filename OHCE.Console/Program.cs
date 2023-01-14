using OHCE;

namespace OHCE.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Veuillez rentrer un mot pour en obtenir l'inverse : ");
            System.Console.WriteLine("PS. : Si ce mot est un mirroir de types palindrome, 'Bien dit' vous sera renvoyé...");
            System.Console.WriteLine(Mirror.returnMirror(System.Console.ReadLine() ?? String.Empty));
            
        }
    }
}

