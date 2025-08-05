# CatFactApp

Aplikacja konsolowa .NET, kt�ra pobiera losowy fakt o kotach z publicznego API i zapisuje go do pliku txt.

## Funkcje

- Obs�u�y wiele ciekawostek � naci�nij `c`, by pobra� kolejn�.
- Zako�czy aplikaj� naciskaj�c `q`.
- Pobiera losow� ciekawostk� o kotach z API [`catfact.ninja`](https://catfact.ninja/fact).
- Zapisuje dane w pliku txt: `Data/cat_facts.txt`.
- Automatycznie tworzy katalog `Data`, je�li nie istnieje.
- Zawsze zapisuje plik w katalogu projektu, niezale�nie od miejsca uruchomienia aplikacji np. Visual Studio, Power Shell.
- Gdy plik nie istnieje, to przy zapisaniu pierwszego faktu, tworzy go z nag��wkiem 'facts,length'.
- Gdy plik istnieje, dodaje nowy fakt na ko�cu pliku bez duplikowania nag��wka.

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

3. Uruchom aplikacj�:
    ```bash
    dotnet run
    ```

Po uruchomieniu, nowy fakt o kotach zostanie zapisany do pliku `Data/cat_facts.txt` w formacie txt.

## Struktura projektu

- `App.cs` � g��wna logika aplikacji.
- `Services/CatFactService.cs` � pobieranie fakt�w o kotach z API.
- `Utils/FileWriter.cs` � zapisywanie fakt�w do pliku txt.
- `Models/CatFact.cs` � model danych faktu o kocie.

## Przyk�ad zapisu w pliku

```
facts,length
Cats have five toes on their front paws, but only four on the back.,63
```

## Zale�no�ci

Projekt korzysta wy��cznie z oficjalnych pakiet�w Microsoft dost�pnych na NuGet:

- `Microsoft.Extensions.DependencyInjection`
- `Microsoft.Extensions.Hosting`
- `Microsoft.Extensions.Http`

Nie s� u�ywane �adne zewn�trzne biblioteki spoza ekosystemu Microsoft.

## Uwagi

- Kod zosta� napisany z my�l� o czytelno�ci i �atwej rozbudowie.
- Zastosowano Dependency Injection przy wykorzystaniu oficjalnych bibliotek Microsoft.
- Aplikacja nie wymaga konfiguracji poza standardowym �rodowiskiem .NET.

## Autor

Rafa� Raczy�ski
