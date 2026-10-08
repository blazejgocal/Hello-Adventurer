//Console.WriteLine("Podaj imię bohatera: ");
//string imie = Console.ReadLine()!;
//Console.WriteLine("Podaj maksymalną liczbę punktów życia: ");
//string maxPunktyZycia = Console.ReadLine()!;
//Console.WriteLine("Podaj aktualną liczbę punktów życia: ");
//string aktualnePunktyZycia = Console.ReadLine()!;
//Console.WriteLine("Podaj podstawowe obrażenia broni: ");
//string obrazeniaBroni = Console.ReadLine()!;
//Console.WriteLine("Podaj premię obrażeń broni: ");
//string premiaObrazenBroni = Console.ReadLine()!;
//Console.WriteLine("Podaj mnożnik obrażeń broni: ");
//string mnoznikObrazenBroni = Console.ReadLine()!;
//Console.WriteLine("Podaj liczbę wykonanych ataków: ");
//string liczbaAtakow = Console.ReadLine()!;
//int maxPunktyZycia1 = int.Parse(maxPunktyZycia);
//int aktualnePunktyZycia1 = int.Parse(aktualnePunktyZycia);
//int obrazeniaBroni1 = int.Parse(obrazeniaBroni);
//int premiaObrazenBroni1 = int.Parse(premiaObrazenBroni);
//double mnoznikObrazenBroni1 = double.Parse(mnoznikObrazenBroni);
//int liczbaAtakow1 = int.Parse(liczbaAtakow);
//int zwyklyAtak = obrazeniaBroni1 + premiaObrazenBroni1;
//int specjalnyAtak = (int)(zwyklyAtak * mnoznikObrazenBroni1);
//int sumaObrazen = (zwyklyAtak * liczbaAtakow1) + specjalnyAtak;
//double procentZdrowia = (double)aktualnePunktyZycia1 / maxPunktyZycia1 * 100;
//Console.WriteLine("========== RAPORT Z WALKI ==========");
//Console.WriteLine($"Imię bohatera: {imie}");
//Console.WriteLine($"Zrowie: {aktualnePunktyZycia1}/{maxPunktyZycia1} ({procentZdrowia}%)");
//Console.WriteLine($"Zwykły atak: {zwyklyAtak}");
//Console.WriteLine($"Specjalny atak: {specjalnyAtak}");
//Console.WriteLine($"Suma obrażeń: {sumaObrazen}");
//if(procentZdrowia > 0)//
//{
//    bool zyje = true;
//    Console.WriteLine($"Żyje: {zyje}");
//}
//else//
//{
//    bool zyje = false;
//    Console.WriteLine($"Żyje: {zyje}");
//}
//if (procentZdrowia == 100)
//{
//    bool maPelneZdrowie = true;
//    Console.WriteLine($"Ma pełne zdrowie: {maPelneZdrowie}");
//}
//else
//{
//    bool maPelneZdrowie = false;
//    Console.WriteLine($"Ma pełne zdrowie: {maPelneZdrowie}");
//}
//Console.WriteLine("====================================");