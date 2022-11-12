# Hra karkulka
## Požadavky 💻
- **[Nový Windows Terminal](https://www.microsoft.com/en-us/p/windows-terminal/9n0dx20hk701?activetab=pivot:overviewtab)**
- .NET Core

## Jak hrát 🎮
Ovládání je pomocí psaní klíčových slov do konzole.
- `dolu` - posune karkulku dolů
- `nahoru` - posune karkulku nahoru
- `doleva` - posune karkulku doleva
- `doprava` - posune karkulku doprava

Cílem hry je dostat karkulku do cíle. Cílem je babičin domeček `🏠`.
Cestou můžeš potkat různé speciální políčka, která mohou mít různé efekty.
- `🧱 Překážka` - zde musíš zodpovědět matematickou otázku, aby jsi mohl pokračovat. Když odpovíš špatně, tak karkulka příjde o jeden dárek.
- `🌸 Květinová louka` - zde získáš jeden dárek. Můžeš ovšem sbírat pouze jednou za celou hru.
- `🐺 Vlk` - zde vlk zjistí, že jdeš za babičkou. Když se zdržíš na květinové louce, tak vlk bude u babičky dřív a sežere vás obě.
- `🟩 Vyhlídka` - zde se nic speciálního neděje. Můžeš se zde zastavit a porozhlédnout se.
- `🏠 Babičin domeček` - zde se nachází babička. Když se zde dostaneš s minimálně dvěmi dárky a po cestě jsi nepotkal/a vlka, tak vyhráváš.
- `🌳 Bludny kořen` - zde budeš teleportován/a na náhodné místo na mapě okolo kořene.
- `🏯 Domov karkulky` - zde se spawnuješ na začátku hry.

## Jak spustit hru 🚀
1. Stáhni si .NET Core SDK z [oficiálních stránek](https://dotnet.microsoft.com/download/dotnet/5.0).
2. Stáhni si tento repozitář.
3. Otevři si složku `hra-karkulka` v terminálu.
4. Spusť příkaz `dotnet run`.

## Licence 📜
Tento repozitář je licencován pod MIT licencí. Více informací v souboru [LICENSE](LICENSE).