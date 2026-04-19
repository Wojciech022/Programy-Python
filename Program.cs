using System;

class Program
{
    static void Zadanie1Kalkulator()
    {
        Console.WriteLine("\n=== Zadanie 1: Prosty kalkulator dwóch liczb ===");

        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj operator (+, -, *, /): ");
        string op = Console.ReadLine();

        if (op == "+")
        {
            Console.WriteLine("Wynik: " + (a + b));
        }
        else if (op == "-")
        {
            Console.WriteLine("Wynik: " + (a - b));
        }
        else if (op == "*")
        {
            Console.WriteLine("Wynik: " + (a * b));
        }
        else if (op == "/")
        {
            if (b != 0)
                Console.WriteLine("Wynik: " + (a / b));
            else
                Console.WriteLine("Błąd: nie można dzielić przez zero.");
        }
        else
        {
            Console.WriteLine("Błąd: nieznany operator.");
        }
    }

    static void Zadanie2KonwerterTemperatur()
    {
        Console.WriteLine("\n=== Zadanie 2: Konwerter temperatur ===");

        Console.Write("Wybierz kierunek konwersji (c - Celsjusz na Fahrenheit, f - Fahrenheit na Celsjusz): ");
        string kierunek = Console.ReadLine().ToLower();

        Console.Write("Podaj temperaturę: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (kierunek == "c")
        {
            double wynik = temp * 1.8 + 32;
            Console.WriteLine($"{temp}°C = {wynik:F2}°F");
        }
        else if (kierunek == "f")
        {
            double wynik = (temp - 32) / 1.8;
            Console.WriteLine($"{temp}°F = {wynik:F2}°C");
        }
        else
        {
            Console.WriteLine("Błąd: niepoprawny wybór.");
        }
    }

    static void Zadanie3SredniaOcen()
    {
        Console.WriteLine("\n=== Zadanie 3: Średnia ocen ucznia ===");

        Console.Write("Ile ocen chcesz podać? ");
        int liczbaOcen = Convert.ToInt32(Console.ReadLine());

        double suma = 0;

        for (int i = 0; i < liczbaOcen; i++)
        {
            Console.Write($"Podaj ocenę {i + 1}: ");
            double ocena = Convert.ToDouble(Console.ReadLine());
            suma += ocena;
        }

        double srednia = suma / liczbaOcen;
        Console.WriteLine($"Średnia: {srednia:F2}");

        if (srednia >= 3.0)
            Console.WriteLine("Uczeń zdał.");
        else
            Console.WriteLine("Uczeń nie zdał.");
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Prosty kalkulator dwóch liczb");
            Console.WriteLine("2 - Konwerter temperatur");
            Console.WriteLine("3 - Średnia ocen ucznia");
            Console.WriteLine("0 - Wyjście");
            Console.Write("Wybierz zadanie: ");

            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Zadanie1Kalkulator();
                    break;
                case "2":
                    Zadanie2KonwerterTemperatur();
                    break;
                case "3":
                    Zadanie3SredniaOcen();
                    break;
                case "0":
                    Console.WriteLine("Koniec programu.");
                    return;
                default:
                    Console.WriteLine("Niepoprawny wybór.");
                    break;
            }
        }
    }
}
