using System.Globalization;
using System.Reflection.Metadata.Ecma335;
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
                    // var alder = AnsiConsole.Ask<int>("");
                    string? alder = Console.ReadLine();

                    if (int.TryParse(alder, out dinAlder))
                    {
                        if (dinAlder <= 15)
                        {
                            AnsiConsole.MarkupLine(
                                "[bold red]Du er desverre ikke gammel nok til å få farge\nProgrammet vil avslutte automatisk etter 3 sekunder[/]"
                            );
                            Thread.Sleep(2500);
                            Environment.Exit(0);
                        }
                        else if (dinAlder >= 16)
                        {
                            break;
                        }
                    }
                    else
                    {
                        AnsiConsole.MarkupLine(
                            "[bold red]Det er kun tall!!![/]Vent litt å prøv på nytt"
                        );

                        Thread.Sleep(1000);
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
                AnsiConsole.Markup("----------");
                Thread.Sleep(200);
                AnsiConsole.Markup("------------------");
                Thread.Sleep(200);
                AnsiConsole.Markup("-------------------------");
                Thread.Sleep(200);

                AnsiConsole.MarkupLine(" [green] Finished[/]");
                Thread.Sleep(500);
                // here will the programm choose where user belongs to based on the age

                Table table = new Table();
                table.Border(TableBorder.Rounded);
                table.Title("Colors");
                table.ShowRowSeparators();
                table.AddColumn("Navn");
                table.AddColumn("Alder");
                table.AddColumn("Sted");
                table.AddColumn("Farge");
                table.Centered();

                switch (dinAlder)
                {
                    case >= 16 and <= 25:
                    {
                        string? farge = "blå";
                        table.AddRow($"{name}", $"{dinAlder}", $"{bor}", $"{farge}");

                        table.BorderColor(Color.Blue);

                        break;
                    }
                    case >= 26 and <= 45:
                    {
                        string? farge = "Gul";
                        table.AddRow($"{name}", $"{dinAlder}", $"{bor}", $"{farge}");
                        table.BorderColor(Color.Yellow);
                        break;
                    }
                    case >= 46 and <= 75:
                    {
                        string? farge = "Grøn";
                        table.AddRow($"{name}", $"{dinAlder}", $"{bor}", $"{farge}");
                        table.BorderColor(Color.Green);
                        break;
                    }
                    case >= 76 and <= 99:
                    {
                        string? farge = "Rosa";
                        table.AddRow($"{name}", $"{dinAlder}", $"{bor}", $"{farge}");
                        table.BorderColor(Color.Pink1);
                        break;
                    }
                    default:
                    {
                        //  string? farge = "Rød";
                        table.AddRow($"Du", $"Er", $"DØD", $"!!!!");
                        table.BorderColor(Color.Red);
                        break;
                    }
                }

                AnsiConsole.Write(table);
                Console.ReadKey();

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
        }
    }
}
