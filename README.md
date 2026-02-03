Návrhový vzor Šablonová metoda se používá v situacích, kdy je nutné pevně dané pořadí kroků algoritmu, ale některé kroky se mohou lišit podle konkrétní implementace. Zajišťuje, že se všechny povinné kroky vždy provedou správně.

Proč jsme ji zvolili v této implementaci:
Při přepínání obrazovek termostatu je nutné vždy dodržet bezpečnostní protokol (inicializace hardwaru, vykreslení obsahu, uvolnění paměti). Šablonová metoda vynucuje toto pořadí a zároveň umožňuje programátorům definovat pouze vlastní obsah obrazovky, aniž by museli řešit technické detaily nebo riziko porušení bezpečnostních pravidel.
