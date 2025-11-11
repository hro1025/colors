using System.Globalization;
using Spectre.Console;

namespace colors;

class Program
{
    static void Main(string[] args)
    {
        bool repeatProgram = true;

        while (repeatProgram)
        {
            // output by the programm (saying hello and ask if you are ready to find your color)
            AnsiConsole.MarkupLine(
                "[bold]Heisann og velkommen til COLORS![/]\nEr du klar til å finne ut fargen din? ([bold]ja [/]eller [bold]nei[/])"
            );
            // input by the user ('ja' eller 'nei')
            string? input = Console.ReadLine();

            // if 'nei': will the program close
            if (input == "nei" || input == "Nei")
            {
                AnsiConsole.MarkupLine(
                    "[bold]Skjønner[/] 😭😭\nProgrammet vil automatisk avsluttet etter 3 sekunder"
                );
                Thread.Sleep(2500);
                Environment.Exit(0);
            }
            // else if 'ja': will the programm continue and ask for the users name
            else if (input == "ja" || input == "Ja")
            {
                AnsiConsole.MarkupLine("[bold]Great[/], lets go :)\nHva er navnet ditt?");
                string? name = Console.ReadLine();
                int dinAlder;
                while (true)
                {
                    AnsiConsole.MarkupLine("Hva med din alder?");
                    string? alder = Console.ReadLine();

                    if (int.TryParse(alder, out dinAlder))
                    {
                        break;
                    }
                    else
                    {
                        AnsiConsole.MarkupLine("[bold red]Det er kun tall!!![/]");
                    }
                }

                AnsiConsole.MarkupLine("Hvor er det du bor?");
                string? bor = Console.ReadLine();

                AnsiConsole.MarkupLine(
                    "[bold]Takk for informasjonen[/]\nVent litt mens jeg kalkulere din input"
                );
                AnsiConsole.Markup("[bold]Loading [/]");
                Thread.Sleep(500);
                AnsiConsole.Markup("-");
                Thread.Sleep(200);
                AnsiConsole.Markup("-");
                Thread.Sleep(200);
                AnsiConsole.Markup("-");
                Thread.Sleep(200);
                AnsiConsole.Markup("-");
                Thread.Sleep(200);
                AnsiConsole.Markup("-");
                Thread.Sleep(200);
                AnsiConsole.Markup("-");
                Thread.Sleep(200);

                AnsiConsole.MarkupLine(" [green] Finished[/]");
                Thread.Sleep(500);

                switch (dinAlder)
                {
                    case < 20:
                    {
                        Console.WriteLine("good");
                        break;
                    }
                }

                repeatProgram = false;
            }
            // else = if the user write someting exept 'ja' or 'nei' will the program repeat the first output
            else
            {
                AnsiConsole.MarkupLine(
                    "[bold red]Det er kun ja eller nei!!!\nVent 3 sekunder å prøv på nytt[/]"
                );
                Thread.Sleep(2500);
            }

            // input: here will the user write down the name

            // output: here will it ask how old the user is
            // input: here will the user write down how old the user is

            // if: is the age under 16 it will say the user is not old enough
            // if else: it will continue the program

            //output: here will the programm ask where the user lives
            //input: here will the write down the answer

            //here will the user be set into an color depends on what input the program got
        }
    }
}
