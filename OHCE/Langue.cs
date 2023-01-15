using OHCE.Interfaces;

namespace OHCE;

public class Langue : ILangue
{
    public string BienDit { get; }
    public string DireBonjour { get; }
    public string AuRevoir { get; }
    
    public Langue(string langue)
    {
        switch (langue)
        {
            case "fr":
                BienDit = "Bien dit!";
                DireBonjour = "Bonjour !";
                AuRevoir = "Au revoir !";
                break;
            case "en":
                BienDit = "Well said!";
                DireBonjour = "Hello !";
                AuRevoir = "Goodbye !";
                break;
            default:
                BienDit = "Language not supported";
                DireBonjour = "Language not supported";
                AuRevoir = "Language not supported";
                break;
        }
    }
}