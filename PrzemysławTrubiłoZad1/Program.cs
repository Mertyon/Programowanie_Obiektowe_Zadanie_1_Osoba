using System;

namespace PrzemysławTrubiłoZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba ad = new Osoba();

            ad.Dane();
            ad.Data();
            ad.Czas_Życia();
        }

        class Osoba
        {
            public string imie;
            public string nazwisko;
            DateTime? data_Urodzenia = new DateTime(2022, 2, 24);
            DateTime? data_Śmierci = new DateTime(2022, 6, 22); // po ustawieniu null powinno obliczać ile ma PEŁNYCH lat obecnie.
            DateTime today = DateTime.Now;

            public Osoba()
            {
                string imieNazwisko = imie + " " + nazwisko;
            }

            public void Dane()
            {
                imie = "Kamil";
                nazwisko = "Ślimak";

                if (imie == null && nazwisko == null)
                {
                    Console.WriteLine("*Bark danych o imieniu i nazwisku*");
                }
                else if (imie == null)
                {
                    Console.WriteLine("*Brak podanego imienia* " + nazwisko);
                }
                else if (nazwisko == null)
                {
                    Console.WriteLine(imie + " *Brak podeanego nazwiska*");
                }
                else Console.WriteLine(imie + " " + nazwisko);
            }

            public void Data()
            {

                if (data_Śmierci != null)
                {
                    Console.WriteLine("Urodzony: " + data_Urodzenia);
                    Console.WriteLine("Zmarły: " + data_Śmierci);
                }
                else Console.WriteLine("Urodzony: " + data_Urodzenia);

            }

            public void Czas_Życia()
            {
                if (data_Śmierci == null)
                {
                    TimeSpan żyje = ((TimeSpan)(today - data_Urodzenia));
                    double ile_Ma_Lat = Math.Floor(żyje.TotalDays / 365);

                    // jeśli jednak żyje
                    if (ile_Ma_Lat % 10 == 0)
                    {
                        Console.WriteLine("Żyje do dziś i ma " + ile_Ma_Lat + " Lat");
                    }
                    else if (ile_Ma_Lat > 20)
                    {
                        if (ile_Ma_Lat % 2 == 0)
                        {
                            Console.WriteLine("Żyje do dziś i ma " + ile_Ma_Lat + " Lata");

                        }
                        else Console.WriteLine("Żyje do dziś i ma " + ile_Ma_Lat + " Lat");
                    }
                    else if (ile_Ma_Lat >= 5) 
                    {
                        Console.WriteLine("Żyje do dziś i ma " + ile_Ma_Lat + " Lat"); 
                    }
                    else Console.WriteLine("Żyje do dziś i ma " + ile_Ma_Lat + " Lata");
                }  
                else if (data_Śmierci != null)
                {
                    TimeSpan czasŻycia = ((TimeSpan)(data_Śmierci - data_Urodzenia));
                    double ile_Lat_Żył = Math.Floor(czasŻycia.TotalDays / 365);

                    // jeśli nie żyje
                    if (data_Śmierci != null)
                    {
                        if (ile_Lat_Żył % 10 == 0)
                        {
                            Console.WriteLine("Żył " + ile_Lat_Żył + " Lat");
                        }
                        else if (ile_Lat_Żył > 20)
                        {
                            if (ile_Lat_Żył % 2 == 0)
                            {
                                Console.WriteLine("Żył " + ile_Lat_Żył + " Lata");

                            }
                            else Console.WriteLine("Żył " + ile_Lat_Żył + " Lat");
                        }
                        else if (ile_Lat_Żył >= 5)
                        {
                            Console.WriteLine("Żył " + ile_Lat_Żył + " Lat");
                        }
                        else Console.WriteLine("Żył " + ile_Lat_Żył + " Lata");
                    }
                }
            }
        }
    }
}
