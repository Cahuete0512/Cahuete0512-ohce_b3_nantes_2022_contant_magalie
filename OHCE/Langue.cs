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
                break;
            case "en":
                BienDit = "Well said!";
                break;
            default:
                BienDit = "Language not supported";
                break;
        }
    }
}