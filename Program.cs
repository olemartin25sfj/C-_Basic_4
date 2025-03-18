using System.Reflection.Metadata.Ecma335;

namespace C__Basic_4;

class Program
{
    static void Main()
    {
        string filePath = "DigiDB_digimonlist.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Filen {filePath} ble ikke funnet! Plasser den i samme mappe som programmet.");
            return;
        }

        DigimonController controller = new DigimonController(filePath);
        controller.Run();
    }
}
