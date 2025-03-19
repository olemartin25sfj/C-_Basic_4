using System;
using System.Collections.Generic;
using System.Linq;

public class DigimonController
{
    private readonly List<Digimon> _digimons;

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
            HandleUserChoice(input);
        }
    }

    private void HandleUserChoice(string input)
    {

        switch (input)
        {
            case "1":
                PrintAllDigimons();
                break;
            case "2":
                SearchByName();
                break;
            case "3":
                FilterByType();
                break;
            case "4":
                FilterByStage();
                break;
            case "5":
                FindStrongestDigimon();
                break;
            case "6":
                Console.WriteLine("Avslutter...");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Ugyldig valg. Prøv igjen!");
                break;


        }
    }

    private void PrintAllDigimons()
    {
        _digimons.ForEach(Console.WriteLine);
    }
    private void SearchByName()
    {
        Console.WriteLine("Skriv inn navn: ");
        string name = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(name)) return;

        var found = _digimons.Where(d => d.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine(found.Any() ? string.Join("\n", found) : "Ingen treff.");
    }

    private void FilterByType()
    {
        Console.Write("Skriv inn type (Data, Free, Vaccine, Virus): ");
        string type = Console.ReadLine()?.Trim();
        var byType = _digimons.Where(d => d.Type.Equals(type, StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine(byType.Any() ? string.Join("\n", byType) : "Ingen Digimon funnet med denne typen.");
    }

    private void FilterByStage()
    {
        Console.Write("Skriv inn stage (Baby, In-Training, Rookie, Champion, Ultimate, Mega): ");
        string stage = Console.ReadLine()?.Trim();
        var byStage = _digimons.Where(d => d.Stage.Equals(stage, StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine(byStage.Any() ? string.Join("\n", byStage) : "Ingen Digimon funnet med dette stage-nivået.");
    }

    private void FindStrongestDigimon()
    {
        if (_digimons.Any())
        {
            var strongest = _digimons.MaxBy(d => d.Attack);
            Console.WriteLine($"Sterkeste Digimon: {strongest}");
        }
        else
        {
            Console.WriteLine("Ingen data tilgjengelig.");
        }
    }
}


