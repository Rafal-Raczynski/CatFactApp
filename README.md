# CatFactApp

Aplikacja konsolowa .NET, która pobiera losowy fakt o kotach z publicznego API i zapisuje go do pliku txt.

## Funkcje

- Obs³u¿y wiele ciekawostek – naciœnij `c`, by pobraæ kolejn¹.
- Zakoñczy aplikajê naciskaj¹c `q`.
- Pobiera losow¹ ciekawostkê o kotach z API [`catfact.ninja`](https://catfact.ninja/fact).
- Zapisuje dane w pliku txt: `Data/cat_facts.txt`.
- Automatycznie tworzy katalog `Data`, jeœli nie istnieje.
- Zawsze zapisuje plik w katalogu projektu, niezale¿nie od miejsca uruchomienia aplikacji np. Visual Studio, Power Shell.
- Gdy plik nie istnieje, to przy zapisaniu pierwszego faktu, tworzy go z nag³ówkiem 'facts,length'.
- Gdy plik istnieje, dodaje nowy fakt na koñcu pliku bez duplikowania nag³ówka.

## Wymagania

- .NET 8.0 lub nowszy

## Instalacja i uruchomienie

1. Sklonuj repozytorium:
    ```bash
    git clone https://github.com/Rafal-Raczynski/CatFactApp.git
    cd CatFactApp
    ```

2. Zbuduj projekt:
    ```bash
    dotnet build
    ```

3. Uruchom aplikacjê:
    ```bash
    dotnet run
    ```

Po uruchomieniu, nowy fakt o kotach zostanie zapisany do pliku `Data/cat_facts.txt` w formacie txt.

## Struktura projektu

- `App.cs` – g³ówna logika aplikacji.
- `Services/CatFactService.cs` – pobieranie faktów o kotach z API.
- `Utils/FileWriter.cs` – zapisywanie faktów do pliku txt.
- `Models/CatFact.cs` – model danych faktu o kocie.

## Przyk³ad zapisu w pliku

```
facts,length
Cats have five toes on their front paws, but only four on the back.,63
```

## Zale¿noœci

Projekt korzysta wy³¹cznie z oficjalnych pakietów Microsoft dostêpnych na NuGet:

- `Microsoft.Extensions.DependencyInjection`
- `Microsoft.Extensions.Hosting`
- `Microsoft.Extensions.Http`

Nie s¹ u¿ywane ¿adne zewnêtrzne biblioteki spoza ekosystemu Microsoft.

## Uwagi

- Kod zosta³ napisany z myœl¹ o czytelnoœci i ³atwej rozbudowie.
- Zastosowano Dependency Injection przy wykorzystaniu oficjalnych bibliotek Microsoft.
- Aplikacja nie wymaga konfiguracji poza standardowym œrodowiskiem .NET.

## Autor

Rafa³ Raczyñski
