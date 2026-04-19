def zadanie1_kalkulator():
    print("\n=== Zadanie 1: Prosty kalkulator dwóch liczb ===")
    a = float(input("Podaj pierwszą liczbę: "))
    b = float(input("Podaj drugą liczbę: "))
    op = input("Podaj operator (+, -, *, /): ")

    if op == "+":
        print("Wynik:", a + b)
    elif op == "-":
        print("Wynik:", a - b)
    elif op == "*":
        print("Wynik:", a * b)
    elif op == "/":
        if b != 0:
            print("Wynik:", a / b)
        else:
            print("Błąd: nie można dzielić przez zero.")
    else:
        print("Błąd: nieznany operator.")


def zadanie2_konwerter_temperatur():
    print("\n=== Zadanie 2: Konwerter temperatur ===")
    kierunek = input("Wybierz kierunek konwersji (c - Celsjusz na Fahrenheit, f - Fahrenheit na Celsjusz): ").lower()
    temp = float(input("Podaj temperaturę: "))

    if kierunek == "c":
        wynik = temp * 1.8 + 32
        print(f"{temp}°C = {wynik:.2f}°F")
    elif kierunek == "f":
        wynik = (temp - 32) / 1.8
        print(f"{temp}°F = {wynik:.2f}°C")
    else:
        print("Błąd: niepoprawny wybór.")


def zadanie3_srednia_ocen():
    print("\n=== Zadanie 3: Średnia ocen ucznia ===")
    liczba_ocen = int(input("Ile ocen chcesz podać? "))
    suma = 0

    for i in range(liczba_ocen):
        ocena = float(input(f"Podaj ocenę {i+1}: "))
        suma += ocena

    srednia = suma / liczba_ocen
    print(f"Średnia: {srednia:.2f}")

    if srednia >= 3.0:
        print("Uczeń zdał.")
    else:
        print("Uczeń nie zdał.")


while True:
    print("\n===== MENU =====")
    print("1 - Prosty kalkulator dwóch liczb")
    print("2 - Konwerter temperatur")
    print("3 - Średnia ocen ucznia")
    print("0 - Wyjście")

    wybor = input("Wybierz zadanie: ")

    if wybor == "1":
        zadanie1_kalkulator()
    elif wybor == "2":
        zadanie2_konwerter_temperatur()
    elif wybor == "3":
        zadanie3_srednia_ocen()
    elif wybor == "0":
        print("Koniec programu.")
        break
    else:
        print("Niepoprawny wybór.")
