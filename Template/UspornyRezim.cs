namespace ChytryTermostat;

public class UspornyRezim : Obrazovka
{
    private readonly bool je_aktivni;

    public UspornyRezim(bool aktivni)
    {
        je_aktivni = aktivni;
    }

    protected override void VykresliObsah()
    {
        Console.WriteLine("╔════════════════════════════╗");
        Console.WriteLine("║   ÚSPORNÝ REŽIM            ║");
        Console.WriteLine("╠════════════════════════════╣");
        Console.WriteLine($"║  Status: {(je_aktivni ? "ZAPNUTO 🟢" : "VYPNUTO 🔴")}      ║");
        Console.WriteLine("║  Úspora energie: 30%       ║");
        Console.WriteLine("╚════════════════════════════╝");
    }
}