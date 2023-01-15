namespace OHCE.Test.xUnit;

public class MirrorTest
{
    [Fact(DisplayName =
        "QUAND on saisit une chaîne " +
        "ALORS celle-ci est renvoyée en miroir")]
    public void returnMirrorTest()
    {
        //GIVEN 
        Mirror mirror = new Mirror();
        string stringToReverse = "test";

        //WHEN on saisit une chaîne
        string retour = mirror.returnMirror(stringToReverse);

        //THEN celle-ci est renvoyée en miroir
        Assert.Contains("tset", retour);
    }

    [Fact(DisplayName =
        "QUAND on saisit un palindrome" +
        "ALORS celui-ci est renvoyé" +
        "AND \"bien dit\"  est retourné")]
    public void returnMirrorTestAndSayBienDit()
    {
        //GIVEN 
        Mirror mirror = new Mirror();
        string stringToReverse = "bob";

        //WHEN on saisit une chaîne
        string retour = mirror.returnMirror(stringToReverse);

        //THEN celle-ci est renvoyée en miroir
        //AND "bien dit" est retourné
        Assert.Contains("bob\nBien dit", retour);
    }
    
    [Fact(DisplayName =
        "QUAND on saisit une chaine" +
        "ALORS 'bonjour' est envoyé avant toute reponse")]
    public void bonjourInFirstWhenStringIsWrite()
    {
        //GIVEN 
        string stringIsWrite = "une chaine";
        Mirror mirror = new Mirror();

        //WHEN on saisit une chaîne
        string retour = mirror.returnMirror(stringIsWrite);

        //THEN alors 'bonjour' est envoyé avant toute réponse
        Assert.StartsWith("Bonjour", retour);
    }
    
    [Fact(DisplayName =
        "QUAND on saisit une chaine" +
        "ALORS 'Au revoir' est envoyé en dernier")]
    public void aurevoirInLastWhenStringIsWrite()
    {
        //GIVEN 
        string stringIsWrite = "une chaine";
        Mirror mirror = new Mirror();

        //WHEN on saisit une chaîne
        string retour = mirror.returnMirror(stringIsWrite);
    
        //THEN alors 'aurevoir' est envoyé en dernier
        Assert.EndsWith("Au revoir", retour);
    }
}