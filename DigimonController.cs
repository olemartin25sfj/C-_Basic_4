using System;
using System.Collections.Generic;
using System.Linq;

public class DigimonController
{
    private List<Digimon> _digimons;

    public DigimonController(string filePath)
    {
        _digimons = CsvReader.ReadCsv(filePath);
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("\n1. Se alle Digimon");
            Console.WriteLine("2. Søk etter Digimon");
            Console.WriteLine("3. Filtrer etter type");
            Console.WriteLine("4. Filtrer etter stage");
            Console.WriteLine("5. Finn Digimon med høyest attack");
            Console.WriteLine("6. Avslutt");
            Console.Write("\nVelg et alternativ: ");

            string input = Console.ReadLine()?.Trim();

            switch (input)
            {
                case "1":
                    _digimons.ForEach(Console.WriteLine);
                    break;

                case "2":
                    Console.Write("Skriv inn navn: ");
                    string name = Console.ReadLine()?.Trim();
                    if (!string.IsNullOrEmpty(name))
                    {
                        var found = _digimons.Where(d => d.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
                        if (found.Any())
                            found.ForEach(Console.WriteLine);
                        else
                            Console.WriteLine("Ingen treff.");
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig navn.");
                    }
                    break;

                case "3":
                    Console.Write("Skriv inn type (Data, Free, Vaccine, Virus): ");
                    string type = Console.ReadLine()?.Trim();
                    if (!string.IsNullOrEmpty(type))
                    {
                        var byType = _digimons.Where(d => d.Type.Equals(type, StringComparison.OrdinalIgnoreCase)).ToList();
                        if (byType.Any())
                            byType.ForEach(Console.WriteLine);
                        else
                            Console.WriteLine("Ingen Digimon funnet med denne typen.");
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig input.");
                    }
                    break;

                case "4":
                    Console.Write("Skriv inn stage (Rookie, Champion, Ultimate, Mega): ");
                    string stage = Console.ReadLine()?.Trim();
                    if (!string.IsNullOrEmpty(stage))
                    {
                        var byStage = _digimons.Where(d => d.Stage.Equals(stage, StringComparison.OrdinalIgnoreCase)).ToList();
                        if (byStage.Any())
                            byStage.ForEach(Console.WriteLine);
                        else
                            Console.WriteLine("Ingen Digimon funnet med dette stage-nivået.");
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig input.");
                    }
                    break;

                case "5":
                    if (_digimons.Any())
                    {
                        var strongest = _digimons.OrderByDescending(d => d.Attack).First();
                        Console.WriteLine($"Sterkeste Digimon: {strongest}");
                    }
                    else
                    {
                        Console.WriteLine("Ingen data tilgjengelig.");
                    }
                    break;

                case "6":
                    Console.WriteLine("Avslutter...");
                    return;

                default:
                    Console.WriteLine("Ugyldig valg! Prøv igjen.");
                    break;
            }
        }
    }
}
