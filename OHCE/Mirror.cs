using System.Text;
using OHCE.Interfaces;
using System.Globalization;
using OHCE.Console;

namespace OHCE;

public class Mirror
{
    private ILangue _langue;
    private PeriodeJournee _periodeJournee;

    public Mirror()
    {
        
        switch (CultureInfo.CurrentUICulture.Name)
        {
            case "fr-FR":
                _langue = new Langue("fr");
                break;
            case "en-US":
            case "en-GB":
                _langue = new Langue("en");
                break;
            default:
                _langue = new Langue("fr");
                break;
        }
        _periodeJournee = SystemTimeOfDay.getPeriodeActuelle();
    }

    public Mirror(ILangue langue, PeriodeJournee periodeJournee)
    {
        _langue = langue;
        _periodeJournee = periodeJournee;
    }

    public String returnMirror(String stringToReverse)
    {
        StringBuilder stringBuilder = new StringBuilder(_langue.direBonjour(_periodeJournee))
            .Append("\n");

        string inversed = new string(stringToReverse.Reverse().ToArray());

        stringBuilder.Append(inversed);

        if (stringToReverse.Equals(inversed))
        {
            stringBuilder.Append("\n")
                .Append(_langue.BienDit);
        }

        stringBuilder.Append("\n")
            .Append(_langue.direAurevoir(_periodeJournee));

        return stringBuilder.ToString();
    }
}