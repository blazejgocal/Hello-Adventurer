//Console.WriteLine("Imię: Błażej");
//Console.Write("Kierunek studiów: Informatyka\n");
//Console.WriteLine("Na kursie chciałbym nauczyć się programowania.");


//Console.WriteLine("+------------------------+");
//Console.WriteLine("|\tWIZYTÓWKA\t |");
//Console.WriteLine("+------------------------+");
//Console.WriteLine("| Imię: Błażej\t\t |");
//Console.WriteLine("| Wiek: 18\t\t |");
//Console.WriteLine("| Gra: The Last Of Us II |");
//Console.WriteLine("+------------------------+");


//Console.WriteLine("Jak masz na imię?");
//string imie = Console.ReadLine()!;
//Console.WriteLine("Jaki jest twój ulubiony kolor?");
//string kolor = Console.ReadLine()!;
//Console.WriteLine("Cześć " + imie + "! " + kolor + "  to świetny kolor na płaszcz poszukiwacza przygód.");


//Console.WriteLine("Cześć, ile masz lat?");
//string wiek = Console.ReadLine()!;
//int wiek2 = int.Parse(wiek);
//Console.WriteLine($"Za rok będziesz miał/miała {wiek2 + 1} lat a za pięć lat - {wiek2 + 5} lat");


//Console.WriteLine("Ile kilometrów do celu?");
//string km = Console.ReadLine()!;
//Console.WriteLine("Ile kilometrów pokonanych dziennie?");
//string kmd = Console.ReadLine()!;
//int km1 = int.Parse(km);
//int kmd1 = int.Parse(kmd);
//Console.WriteLine($"Liczba kilomerów do celu: {km1}");
//Console.WriteLine($"Liczba kilometrów pokonywanych dziennie: {kmd1}");
//Console.WriteLine($"Liczba dni do celu: {km1/kmd1}");



//Console.WriteLine("Liczba złotych monet:");
//string zl = Console.ReadLine()!;
//Console.WriteLine("Liczba srebrnych monet:");
//string sr = Console.ReadLine()!;
//Console.WriteLine("Liczba miedzianych monet:");
//string mi = Console.ReadLine()!;
//int zl1 = int.Parse(zl);
//int sr1 = int.Parse(sr);
//int mi1 = int.Parse(mi);
//Console.WriteLine($"Łączna wartośc sakiewki to {mi1 + (zl1*100) + (sr1*10)} miedzianych monet.");


//Console.WriteLine("Ile mikstur chcesz przygotować?");
//string m = Console.ReadLine()!;
//int m1 = int.Parse(m);
//Console.WriteLine("Lista potrzebnych składników:");
//Console.WriteLine($"Kryształy - {m1*3}");
//Console.WriteLine($"Zioła - {m1*2}");


//Console.WriteLine("Cena noclegu:");
//string cena = Console.ReadLine()!;
//Console.WriteLine("Liczba nocy:");
//string noce = Console.ReadLine()!;
//decimal cena1 = decimal.Parse(cena);
//int noce1 = int.Parse(noce);
//Console.WriteLine($"Cena całego pobytu to {cena1*noce1}");


//Console.WriteLine("Podaj liczbę sekund: ");
//string sekundy = Console.ReadLine()!;
//int sekundy1 = int.Parse(sekundy);
//int minuty = sekundy1/60;
//Console.WriteLine($"{sekundy1} sekund to {minuty} minuty i {sekundy1%60} sekundy");


//Console.WriteLine("Liczba monet ze skarbu: ");
//string monety = Console.ReadLine()!;
//Console.WriteLine("Liczba Bohaterów: ");
//string b = Console.ReadLine()!;
//int monety1 = int.Parse(monety);
//int b1 = int.Parse(b);
//Console.WriteLine($"{monety1/b1} monet otrzyma każdy gracz, a {monety1%b1} monet zostanie po równym podziale.");


//Console.WriteLine("Wartość podstawowych obrażeń: ");
//string obr = Console.ReadLine()!;
//Console.WriteLine("Wartość premii do siły: ");
//string pr = Console.ReadLine()!;
//int obr1 = int.Parse(obr);
//int pr1 = int.Parse(pr);
//int za = obr1+pr1;
//int sa = (obr1+pr1)*2;
//Console.WriteLine($"Obrażenia zwykłego ataku to {za}");
//Console.WriteLine($"Obrażenia ataku specjalnego to {sa}");
//Console.WriteLine($"Suma obrażeń od trzech zwykłych ataków oraz jednego specjalnego ataku to {3*za + sa}");


Console.WriteLine("Nazwa bohatera: ");
string nazwab = Console.ReadLine()!;
Console.WriteLine("Nazwa krainy: ");
string nazwak = Console.ReadLine()!;
Console.WriteLine("Liczba dni wyprawy: ");
string ldw = Console.ReadLine()!;
Console.WriteLine("Liczba zdobytych PD: ");
string PD = Console.ReadLine()!;
Console.WriteLine("Liczba zebranego złota: ");
string zl = Console.ReadLine()!;
decimal ldw1 = decimal.Parse(ldw);
decimal PD1 = decimal.Parse(PD);
decimal zl1 = decimal.Parse(zl);
decimal srPD = PD1/ldw1;
decimal srzl = zl1/ldw1;
Console.WriteLine("+------------------------+");
Console.WriteLine("|\tDZIENNIK\t |");
Console.WriteLine("+------------------------+");
Console.WriteLine($"| Nazwa bohatera: {nazwab}");
Console.WriteLine($"| Nazwa krainy: {nazwak}");
Console.WriteLine($"| Liczba dni wyprawy: {ldw1}");
Console.WriteLine($"| Liczba zdobytych PD: {PD1}");
Console.WriteLine($"| Liczba zebranego złota: {zl1}");
Console.WriteLine($"| Średnia liczba zdobytych PD dziennie: {srPD}");
Console.WriteLine($"| Średnia liczba zebranego złota dziennie: {srzl}");
Console.WriteLine($"+------------------------+");
// github test