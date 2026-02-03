namespace ChytryTermostat;

public abstract class Obrazovka
{
    public void Zobrazit()
    {
        InicializovatHardware();
        VykresliObsah();
        UvolnitPamet();
    }

    private void InicializovatHardware()
    {
        Console.WriteLine("[HARDWARE] Připojování k senzorům...");
        Thread.Sleep(100);
        Console.WriteLine("[HARDWARE] Senzory připojeny ✓");
    }

    protected abstract void VykresliObsah();

    private void UvolnitPamet()
    {
        Console.WriteLine("[HARDWARE] Odpojování senzorů...");
        Thread.Sleep(100);
        Console.WriteLine("[HARDWARE] Paměť uvolněna ✓");
        Console.WriteLine();
    }
}