namespace OHCE.Interfaces;

public interface ILangue
{
    string BienDit { get; }

    public String direBonjour(PeriodeJournee periode);
    public String direAurevoir(PeriodeJournee periode);

}