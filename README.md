# Zgadnij Zgadula 2 (PL)

Sequel gry "Zgadnij liczbę" napisany w C# z podejściem obiektowym.

---

## Wymagania

- [.NET 6.0 lub nowszy](https://dotnet.microsoft.com/en-us/download)
- System operacyjny: Windows, macOS lub Linux

Aby sprawdzić czy masz zainstalowany .NET, otwórz terminal i wpisz:
```
dotnet --version
```
Jeśli widzisz numer wersji (np. `8.0.0`), jesteś gotowy. Jeśli nie — pobierz .NET z linku powyżej.

---

## Jak uruchomić grę

1. Pobierz lub sklonuj repozytorium na swój komputer.
2. Otwórz terminal (Windows: `cmd` lub `PowerShell`, macOS/Linux: `Terminal`).
3. Przejdź do folderu z projektem:
```
cd ścieżka/do/folderu/ZgadujZgadula2
```
4. Uruchom grę:
```
dotnet run
```

---

## Jak grać

### Menu główne

Po uruchomieniu gry zobaczysz menu główne z opcjami:
- **1. Nowa gra** — rozpocznij rozgrywkę
- **2. Hall of Fame** — sprawdź najlepsze wyniki *(pojawia się dopiero po rozegraniu przynajmniej jednej gry)*
- **3. Ustawienia** — zmień język, tryb zakładu, wyczyść rekordy
- **4. Wyjście** — zamknij grę

Wpisz numer opcji i naciśnij **Enter**.

---

### Nowa gra

#### 1. Wybór trybu gry
- **1. Standardowa** — klasyczna rozgrywka
- **2. Nowa Gra+** — co kilka strzałów ukryta liczba zostaje przelosowana (tryb zakładu niedostępny)

#### 2. Wybór poziomu trudności
- **1. Łatwy** — liczba od 1 do 50
- **2. Średni** — liczba od 1 do 100
- **3. Trudny** — liczba od 1 do 250

#### 3. Tryb zakładu *(tylko w trybie standardowym)*
Gra zapyta czy chcesz grać w trybie zakładu. Jeśli tak — podaj maksymalną liczbę prób. Jeśli przekroczysz limit, przegrywasz.

#### 4. Zgadywanie
Wpisuj liczby i naciśnij **Enter**. Gra poinformuje Cię czy wpisana liczba jest za mała czy za duża. Po każdej błędnej odpowiedzi zobaczysz losowy komunikat.

#### 5. Nowa Gra+ — przelosowanie
W trybie Nowa Gra+ ukryta liczba zostaje przelosowana co:
- **6 strzałów** na poziomie łatwym
- **7 strzałów** na poziomie średnim
- **8 strzałów** na poziomie trudnym

Na ekranie zawsze widać ile strzałów pozostało do przelosowania.

#### 6. Koniec gry
Po zgadnięciu liczby podaj swoje imię — wynik zostanie zapisany w Hall of Fame.

---

### Hall of Fame

Wyświetla TOP 5 najlepszych wyników dla każdego poziomu trudności. Wyniki są sortowane po liczbie prób, a przy remisie — po czasie rozgrywki (krótszy czas = wyżej).

Wyniki z trybu Nowa Gra+ są oznaczone tagiem **[NG+]**.

Przełączaj poziomy trudności klawiszami **1**, **2**, **3**. Wróć do menu klawiszem **4**.

---

### Ustawienia

- **1. Tryb zakładu** — włącz lub wyłącz pytanie o tryb zakładu przed każdą grą (domyślnie włączony)
- **2. Język** — przełącz między polskim a angielskim
- **3. Wyczyść Hall of Fame** — usuwa wszystkie rekordy (wymaga potwierdzenia wpisaniem `t`)
- **4. Wyjście** — wróć do menu głównego

---

## Struktura projektu

```
ZgadujZgadula2/
├── MainGameScreen/        — logika rozgrywki
│   ├── Difficulty/        — klasy poziomów trudności
│   ├── MainGame.cs
│   ├── NewGame.cs
│   ├── GameSession.cs
│   └── ...
├── HallOfFameScreen/      — ekran wyników
├── SettingsScreen/        — ustawienia i języki
│   └── Languages/         — Polish.cs, English.cs
├── TitleScreen/           — menu główne
├── Shared/                — współdzielone klasy (ScoreEntry)
├── Utils/                 — narzędzia (ASCII)
└── Program.cs             — punkt wejścia
```

---

---

# Zgadnij Zgadula 2 (EN)

Sequel of "Guess the Number" written in C# with an object-oriented approach.

---

## Requirements

- [.NET 6.0 or newer](https://dotnet.microsoft.com/en-us/download)
- Operating system: Windows, macOS or Linux

To check if you have .NET installed, open a terminal and type:
```
dotnet --version
```
If you see a version number (e.g. `8.0.0`), you're ready. If not — download .NET from the link above.

---

## How to run the game

1. Download or clone the repository to your computer.
2. Open a terminal (Windows: `cmd` or `PowerShell`, macOS/Linux: `Terminal`).
3. Navigate to the project folder:
```
cd path/to/folder/ZgadujZgadula2
```
4. Run the game:
```
dotnet run
```

---

## How to play

### Main menu

After launching the game you will see the main menu with options:
- **1. New game** — start a game
- **2. Hall of Fame** — check the best scores *(appears only after at least one game has been played)*
- **3. Settings** — change language, bet mode, clear records
- **4. Exit** — close the game

Type the option number and press **Enter**.

---

### New game

#### 1. Game mode selection
- **1. Standard** — classic gameplay
- **2. New Game+** — every few shots the hidden number gets rerolled (bet mode unavailable)

#### 2. Difficulty selection
- **1. Easy** — number from 1 to 50
- **2. Medium** — number from 1 to 100
- **3. Hard** — number from 1 to 250

#### 3. Bet mode *(standard mode only)*
The game will ask if you want to play in bet mode. If yes — enter the maximum number of attempts. If you exceed the limit, you lose.

#### 4. Guessing
Type numbers and press **Enter**. The game will tell you if the number is too low or too high. After each wrong answer you will see a random message.

#### 5. New Game+ — reroll
In New Game+ mode the hidden number is rerolled every:
- **6 shots** on easy difficulty
- **7 shots** on medium difficulty
- **8 shots** on hard difficulty

The screen always shows how many shots are left until the next reroll.

#### 6. End of game
After guessing the number, enter your name — the score will be saved in the Hall of Fame.

---

### Hall of Fame

Displays the TOP 5 best scores for each difficulty level. Scores are sorted by number of attempts, and in case of a tie — by game time (shorter time = higher).

Scores from New Game+ mode are marked with the **[NG+]** tag.

Switch difficulty levels with keys **1**, **2**, **3**. Return to the menu with key **4**.

---

### Settings

- **1. Bet mode** — enable or disable the bet mode prompt before each game (enabled by default)
- **2. Language** — switch between Polish and English
- **3. Clear Hall of Fame** — removes all records (requires confirmation by typing `t`)
- **4. Exit** — return to the main menu

---

## Project structure

```
ZgadujZgadula2/
├── MainGameScreen/        — game logic
│   ├── Difficulty/        — difficulty level classes
│   ├── MainGame.cs
│   ├── NewGame.cs
│   ├── GameSession.cs
│   └── ...
├── HallOfFameScreen/      — results screen
├── SettingsScreen/        — settings and languages
│   └── Languages/         — Polish.cs, English.cs
├── TitleScreen/           — main menu
├── Shared/                — shared classes (ScoreEntry)
├── Utils/                 — utilities (ASCII)
└── Program.cs             — entry point
```