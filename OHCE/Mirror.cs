namespace OHCE;

public class Mirror
{
    public static String returnMirror(String stringToReverse)
    {
        
        string inversed = new string(stringToReverse.Reverse().ToArray());
        
        if (stringToReverse.Equals(inversed))
        {
            inversed += "\nBien dit";
        }
        
        return inversed;
    }
}