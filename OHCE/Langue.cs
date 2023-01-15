using OHCE.Interfaces;

namespace OHCE;

public class Langue : ILangue
{
    public string BienDit { get; }
    string _langue;
    
    public Langue(string langue)
    {
        _langue = langue;
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

    public String direAurevoir(PeriodeJournee periode)
    {
        String aurevoir;
        switch (periode)
        {
            case PeriodeJournee.Matin:
                aurevoir = aurevoirMatin();
                break;
            case PeriodeJournee.AprèsMidi:
                aurevoir = aurevoirApresMidi();
                break;
            case PeriodeJournee.Soir:
                aurevoir = aurevoirSoir();
                break;
            case PeriodeJournee.Nuit:
                aurevoir = aurevoirNuit();
                break;
            default:
                aurevoir = "Language not supported";
                break;
        }

        return aurevoir;
    }

    private string aurevoirNuit()
    {
        String aurevoir;
        
        switch (_langue)
        {
            case "fr":
                aurevoir = "Au revoir_nuit !";
                break;
            case "en":
                aurevoir = "GoodBye_nuit !";
                break;
            default:
                aurevoir = "Language not supported";
                break;
        }

        return aurevoir;
    }

    private string aurevoirSoir()
    {
        String aurevoir;
        
        switch (_langue)
        {
            case "fr":
                aurevoir = "Au revoir_soir !";
                break;
            case "en":
                aurevoir = "GoodBye_soir !";
                break;
            default:
                aurevoir = "Language not supported";
                break;
        }

        return aurevoir;
    }

    private string aurevoirApresMidi()
    {
        String aurevoir;
        
        switch (_langue)
        {
            case "fr":
                aurevoir = "Au revoir_pm !";
                break;
            case "en":
                aurevoir = "GoodBye_pm !";
                break;
            default:
                aurevoir = "Language not supported";
                break;
        }

        return aurevoir;
    }

    private string aurevoirMatin()
    {
        String aurevoir;
        
        switch (_langue)
        {
            case "fr":
                aurevoir = "Au revoir_am !";
                break;
            case "en":
                aurevoir = "GoodBye_am !";
                break;
            default:
                aurevoir = "Language not supported";
                break;
        }

        return aurevoir;
    }
}