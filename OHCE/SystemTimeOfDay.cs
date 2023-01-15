namespace OHCE.Console;

public class SystemTimeOfDay
{
    private const int debutMatin = 5;
    private const int debutApresMidi = 14;
    private const int debutSoir = 18;
    private const int debutNuit = 22;

    public static PeriodeJournee getPeriodeActuelle()
    {
        PeriodeJournee periodeActuelle;

        DateTime heure = DateTime.Now;

        if (heure.Hour >= debutNuit && heure.Hour < debutMatin)
        {
            periodeActuelle = PeriodeJournee.Nuit;
        }
        else if (heure.Hour >= debutSoir)
        {
            periodeActuelle = PeriodeJournee.Soir;
        }
        else if (heure.Hour >= debutApresMidi)
        {
            periodeActuelle = PeriodeJournee.AprèsMidi;
        }
        else
        {
            periodeActuelle = PeriodeJournee.Matin;
        }

        return periodeActuelle;
    }
}