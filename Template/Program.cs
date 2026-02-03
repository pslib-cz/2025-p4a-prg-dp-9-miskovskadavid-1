using ChytryTermostat;

Console.WriteLine("Hello, World!");

Console.WriteLine("=== SYSTÉM CHYTRÉHO TERMOSTATU ===\n");

Obrazovka[] obrazovky = [
    new PrehledStavu(22.5, 65),
    new NastaveniTeploty(24.0),
    new UspornyRezim(true),
    new NastaveniTeploty(20.5),
    new UspornyRezim(false)
];

foreach (var obrazovka in obrazovky)
{
    obrazovka.Zobrazit();
}

Console.WriteLine("=== VŠECHNY OBRAZOVKY BEZPEČNĚ ZOBRAZENY ===");
