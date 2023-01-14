namespace OHCE.Test.xUnit;

public class MirrorTest
{
    [Fact(DisplayName =
        "QUAND on saisit une chaîne " +
        "ALORS celle-ci est renvoyée en miroir")]
    public void returnMirrorTest()
    {
        //GIVEN 
        string stringToReverse = "test";

        //WHEN on saisit une chaîne
        string retour = Mirror.returnMirror(stringToReverse);

        //THEN celle-ci est renvoyée en miroir
        Assert.Equal("tset", retour);
    }

    [Fact(DisplayName =
        "QUAND on saisit un palindrome" +
        "ALORS celui-ci est renvoyé" +
        "AND \"bien dit\"  est retourné")]
    public void returnMirrorTestAndSayBienDit()
    {
        //GIVEN 
        string stringToReverse = "bob";

        //WHEN on saisit une chaîne
        string retour = Mirror.returnMirror(stringToReverse);

        //THEN celle-ci est renvoyée en miroir
        //AND "bien dit" est retourné
        Assert.Equal("bob\nBien dit", retour);
    }
}