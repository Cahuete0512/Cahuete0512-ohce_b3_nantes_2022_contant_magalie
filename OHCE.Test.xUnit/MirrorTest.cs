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
    
    [Theory(DisplayName =
        "ETANT DONNE un utilisateur parlant une langue" +
        "QUAND on entre un palindrome" +
        "ALORS il est renvoyé" +
        "ET le <bienDit> de cette langue est envoyé")]
    [InlineData("en")]
    [InlineData("fr")]
    public void bienDitSelonLaLangueUtilisateur(String language)
    {
        // GIVEN : ETANT DONNE un utilisateur parlant une langue
        Langue langue = new Langue(language);
        Mirror mirror = new Mirror(langue);
        string mot = "bob";
        
        // WHEN : QUAND on entre un palindrome
        var retour = mirror.returnMirror(mot);

        // THEN : ALORS il est renvoyé
        Assert.Contains(mot, retour);

        // AND : ET le <bienDit> de cette langue est envoyé
        Assert.Contains(langue.BienDit, retour);
    }
    
    [Theory(DisplayName =
        "ETANT DONNE un utilisateur parlant une langue" +
        "QUAND on saisit une chaine" +
        "ALORS <bonjour> de cette langue est envoyé avant tout")]
    [InlineData("en")]
    [InlineData("fr")]
    public void bonjourSuivantLaLangueUtilisateur(String language)
    {
        // GIVEN : ETANT DONNE un utilisateur parlant une langue
        Langue langue = new Langue(language);
        Mirror mirror = new Mirror(langue);
        string stringIsWrite = "une chaine";
        
        // WHEN : QUAND on saisit une chaine
        var retour = mirror.returnMirror(stringIsWrite);

        // THEN : <bonjour> de cette langue est envoyé avant tout
        Assert.StartsWith(langue.DireBonjour, retour);
    }
    
    [Theory(DisplayName =
        "ETANT DONNE un utilisateur parlant une langue" +
        "QUAND on saisit une chaine" +
        "ALORS <au revoir> de cette langue est envoyé en dernier")]
    [InlineData("en")]
    [InlineData("fr")]
    public void aurevoirSuivantLaLangueUtilisateurEnDernier(String language)
    {
        // GIVEN : ETANT DONNE un utilisateur parlant une langue
        Langue langue = new Langue(language);
        Mirror mirror = new Mirror(langue);
        string stringIsWrite = "une chaine";
        
        // WHEN : QUAND on saisit une chaine
        var retour = mirror.returnMirror(stringIsWrite);

        // THEN : <au revoir> de cette langue est envoyé en dernier
        Assert.EndsWith(langue.AuRevoir, retour);
    }
}