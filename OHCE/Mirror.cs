using System.Text;
using OHCE.Interfaces;

namespace OHCE;

public class Mirror
{
    private ILangue _langue;

    public Mirror()
    {
        _langue = new Langue("en");
    }

    public Mirror(ILangue langue)
    {
        _langue = langue;
    }

    public String returnMirror(String stringToReverse)
    {
        StringBuilder stringBuilder = new StringBuilder(_langue.DireBonjour)
            .Append("\n");

        string inversed = new string(stringToReverse.Reverse().ToArray());

        stringBuilder.Append(inversed);

        if (stringToReverse.Equals(inversed))
        {
            stringBuilder.Append("\n")
                .Append(_langue.BienDit);
        }

        stringBuilder.Append("\nAu revoir");

        return stringBuilder.ToString();
    }
}