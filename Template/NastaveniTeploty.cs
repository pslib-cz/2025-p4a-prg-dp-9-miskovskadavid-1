namespace ChytryTermostat;

public class NastaveniTeploty : Obrazovka
{
    private readonly double cilova_teplota;

    public NastaveniTeploty(double teplota)
    {
        cilova_teplota = teplota;
    }

    protected override void VykresliObsah()
    {
        Console.WriteLine("╔════════════════════════════╗");
        Console.WriteLine("║   NASTAVENÍ TEPLOTY        ║");
        Console.WriteLine("╠════════════════════════════╣");
        Console.WriteLine($"║  Cílová teplota: {cilova_teplota:F1}°C   ║");
        Console.WriteLine("║  [↑] Zvýšit  [↓] Snížit    ║");
        Console.WriteLine("╚════════════════════════════╝");
    }
}