namespace OHCE.Test.xUnit;

public class MirrorTest
{
    [Fact(DisplayName =
        "QUAND on saisit une chaîne " +
        "ALORS celle-ci est renvoyée en miroir")]
    public void returnMirrorTest()
    {
        //GIVEN on saisit une chaîne
        string stringToReverse = "test";

        //WHEN cette chaine est retournée
        string retour = Mirror.returnMirror(stringToReverse);

        //THEN celle-ci est renvoyée en miroir
        Assert.Equal("tset", retour);
    }
}