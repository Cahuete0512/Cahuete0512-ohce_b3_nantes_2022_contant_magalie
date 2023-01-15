using System.Text;
using OHCE.Interfaces;

namespace OHCE;

public class Mirror
{
    private ILangue _langue;
    private PeriodeJournee _periodeJournee;

    public Mirror()
    {
        _langue = new Langue("fr");
        _periodeJournee = PeriodeJournee.Matin;
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