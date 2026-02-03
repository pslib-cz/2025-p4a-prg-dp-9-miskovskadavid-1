namespace ChytryTermostat;

public class PrehledStavu : Obrazovka
{
    private readonly double aktualni_teplota;
    private readonly int vlhkost;

    public PrehledStavu(double teplota, int vlhkost)
    {
        aktualni_teplota = teplota;
        this.vlhkost = vlhkost;
    }

    protected override void VykresliObsah()
    {
        Console.WriteLine("╔════════════════════════════╗");
        Console.WriteLine("║   PŘEHLED STAVU            ║");
        Console.WriteLine("╠════════════════════════════╣");
        Console.WriteLine($"║  Teplota: {aktualni_teplota:F1}°C          ║");
        Console.WriteLine($"║  Vlhkost: {vlhkost}%              ║");
        Console.WriteLine($"║  Čas: {DateTime.Now:HH:mm}              ║");
        Console.WriteLine("╚════════════════════════════╝");
    }
}