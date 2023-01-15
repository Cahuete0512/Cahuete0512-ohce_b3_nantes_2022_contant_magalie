using System.Text;

namespace OHCE;

public class Mirror
{
    public Mirror()
    {
    }

    public String returnMirror(String stringToReverse)
    {
        StringBuilder stringBuilder = new StringBuilder("Bonjour\n");
        
        string inversed = new string(stringToReverse.Reverse().ToArray());

        stringBuilder.Append(inversed);
        
        if (stringToReverse.Equals(inversed))
        {
            stringBuilder.Append("\nBien dit");
        }

        stringBuilder.Append("\nAu revoir");
        
        return stringBuilder.ToString();
    }
}