using OHCE;

namespace OHCE.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Mirror mirror = new Mirror();
            System.Console.WriteLine("Veuillez rentrer un mot pour en obtenir l'inverse : ");
            System.Console.WriteLine("PS. : Si ce mot est un mirroir de types palindrome, 'Bien dit' vous sera renvoyé...");
            System.Console.WriteLine(mirror.returnMirror(System.Console.ReadLine() ?? String.Empty));
            
        }
    }
}

