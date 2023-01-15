using OHCE.Interfaces;

namespace OHCE;

public class Langue : ILangue
{
    public string BienDit { get; }
    public string AuRevoir { get; }
    string _langue;
    
    public Langue(string langue)
    {
        _langue = langue;
        switch (langue)
        {
            case "fr":
                BienDit = "Bien dit!";
                AuRevoir = "Au revoir !";
                break;
            case "en":
                BienDit = "Well said!";
                AuRevoir = "Goodbye !";
                break;
            default:
                BienDit = "Language not supported";
                AuRevoir = "Language not supported";
                break;
        }
    }

    public String direBonjour(PeriodeJournee periode)
    {
        String bonjour;
        switch (periode)
        {
            case PeriodeJournee.Matin:
                bonjour = bonjourMatin();
                break;
            case PeriodeJournee.AprèsMidi:
                bonjour = bonjourApresMidi();
                break;
            case PeriodeJournee.Soir:
                bonjour = bonjourSoir();
                break;
            case PeriodeJournee.Nuit:
                bonjour = bonjourNuit();
                break;
            default:
                bonjour = "Language not supported";
                break;
        }

        return bonjour;
    }

    private string bonjourNuit()
    {
        String bonjour;
        
        switch (_langue)
        {
            case "fr":
                bonjour = "Bonjour_nuit !";
                break;
            case "en":
                bonjour = "Hello_nuit !";
                break;
            default:
                bonjour = "Language not supported";
                break;
        }

        return bonjour;
    }

    private string bonjourSoir()
    {
        String bonjour;
        
        switch (_langue)
        {
            case "fr":
                bonjour = "Bonjour_soir !";
                break;
            case "en":
                bonjour = "Hello_soir !";
                break;
            default:
                bonjour = "Language not supported";
                break;
        }

        return bonjour;
    }

    private string bonjourApresMidi()
    {
        String bonjour;
        
        switch (_langue)
        {
            case "fr":
                bonjour = "Bonjour_pm !";
                break;
            case "en":
                bonjour = "Hello_pm !";
                break;
            default:
                bonjour = "Language not supported";
                break;
        }

        return bonjour;
    }

    private string bonjourMatin()
    {
        String bonjour;
        
        switch (_langue)
        {
            case "fr":
                bonjour = "Bonjour_am !";
                break;
            case "en":
                bonjour = "Hello_am !";
                break;
            default:
                bonjour = "Language not supported";
                break;
        }

        return bonjour;
    }
}