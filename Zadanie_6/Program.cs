Console.WriteLine("Imię bohatera: ");
string imie = Console.ReadLine()!;
Console.WriteLine("Wiek bohatera: ");
string wiek = Console.ReadLine()!;
Console.WriteLine("Płeć bohatera: ");
string plec = Console.ReadLine()!;
Console.WriteLine("Rasa bohatera: ");
string rasa = Console.ReadLine()!;
Console.WriteLine("Symbol bohatera: ");
string symbol = Console.ReadLine()!;
Console.WriteLine("Punkty życia bohatera: ");
string punktyZycia = Console.ReadLine()!;
int punktyZycia1 = int.Parse(punktyZycia);
Console.WriteLine("Punkty doświadczenia bohatera: ");
string punktyDoswiadczenia = Console.ReadLine()!;
int punktyDoswiadczenia1 = int.Parse(punktyDoswiadczenia);
Console.WriteLine("Siła bohatera: ");
string sila = Console.ReadLine()!;
int sila1 = int.Parse(sila);
Console.WriteLine("Zwykłe obrażenia: ");
string zwykleObrazenia = Console.ReadLine()!;
int zwykleObrazenia1 = int.Parse(zwykleObrazenia);
Console.WriteLine("Mnożnik obrażeń: ");
string mnoznikObrazen = Console.ReadLine()!;
double mnoznikObrazen1 = double.Parse(mnoznikObrazen);
double obrazeniaAtakuSpecjalnego = zwykleObrazenia1 * mnoznikObrazen1;

Console.WriteLine("Maksymalne miejsce w plecku: ");
string maksymalneMiejsceWplecku = Console.ReadLine()!;
int maksymalneMiejsceWplecku1 = int.Parse(maksymalneMiejsceWplecku);
Console.WriteLine("Wolne miejsca w plecaku: ");
string wolneMiejscaWplecaku = Console.ReadLine()!;
int wolneMiejscaWplecaku1 = int.Parse(wolneMiejscaWplecaku);
int zajeteMiejscaWplecaku = maksymalneMiejsceWplecku1 - wolneMiejscaWplecaku1;
Console.WriteLine("Zdobyte złoto: ");
string zloto = Console.ReadLine()!;
int zloto1 = int.Parse(zloto);
Console.WriteLine("Liczba członków drużyny: ");
string liczbaCzlonkowDruzyny = Console.ReadLine()!;
int liczbaCzlonkowDruzyny1 = int.Parse(liczbaCzlonkowDruzyny);
int zlotoNaCzlonkaDruzyny = zloto1 / liczbaCzlonkowDruzyny1;
int zlotoPozostale = zloto1 % liczbaCzlonkowDruzyny1;
Console.WriteLine("Czy ma mapę? (true/false): ");
string czyMaMape = Console.ReadLine()!;
bool czyMaMape1 = bool.Parse(czyMaMape);
string lewa = $"Bohater: {imie}";
string prawa = $"{symbol}";

Console.WriteLine("\n\n\n");
Console.WriteLine("+==========================================+");
Console.WriteLine("|             KARTA BOHATERA               |");
Console.WriteLine("+==========================================+");
Console.WriteLine($"| {lewa,-30}{prawa,10} |");
Console.WriteLine("+------------------------------------------+");
Console.WriteLine($"| {$"Wiek: {wiek} lat",-41}|");
Console.WriteLine($"| {$"Płeć: {plec}",-41}|");
Console.WriteLine($"| {$"Rasa: {rasa}",-41}|");
Console.WriteLine($"| {$"Zdrowie: {punktyZycia1}/100",-41}|");
Console.WriteLine($"| {$"Punkty doświadczenia: {punktyDoswiadczenia1}",-41}|");
Console.WriteLine($"| {$"Siła: {sila1}",-41}|");
Console.WriteLine($"| {$"Zwykłe obrażenia: {zwykleObrazenia1}",-41}|");
Console.WriteLine($"| {$"Mnożnik obrażeń: {mnoznikObrazen1}",-41}|");
Console.WriteLine($"| {$"Obrażenia ataku specjalnego: {obrazeniaAtakuSpecjalnego:F2}",-41}|");
Console.WriteLine("+------------------------------------------+");
Console.WriteLine($"| {$"Plecak:  {zajeteMiejscaWplecaku}/{maksymalneMiejsceWplecku1}",-41}|");
Console.WriteLine($"| {$"Wolne miejsca w plecaku: {wolneMiejscaWplecaku1}",-41}|");
Console.WriteLine($"| {$"Zdobyte złoto: {zloto1}",-41}|");
Console.WriteLine($"| {$"Złoto na członka drużyny: {zlotoNaCzlonkaDruzyny}",-41}|");
Console.WriteLine($"| {$"Złoto pozostałe: {zlotoPozostale}",-41}|");
Console.WriteLine("+------------------------------------------+");
if (czyMaMape1)
{
    Console.WriteLine("| Bohater posiada mapę.                    |");
}
else
{
    Console.WriteLine("| Bohater nie posiada mapy.                |");
}
if(punktyZycia1 > 0)
{
    Console.WriteLine("| Bohater żyje.                            |");
}
else
{
    Console.WriteLine("| Bohater nie żyje.                        |");
}
if(punktyZycia1 == 100)
{
    Console.WriteLine("| Bohater jest w pełni zdrowy.             |");
}
else if(punktyZycia1 >= 50)
{
    Console.WriteLine("| Bohater jest ranny.                      |");
}
else
{
    Console.WriteLine("| Bohater jest ciężko ranny.               |");
}
if(punktyZycia1>50 && czyMaMape1 && wolneMiejscaWplecaku1>0)
{
    Console.WriteLine("| Bohater jest gotowy do wyprawy.          |");
}
else
{
    Console.WriteLine("| Bohater nie jest gotowy do wyprawy.      |");
}
Console.WriteLine("+==========================================+");
Console.WriteLine("\n\n\n");