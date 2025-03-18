using System;
using System.Collections.Generic;
using System.IO;

class CsvReader
{
    public static List<Digimon> ReadCsv(string filePath)
    {
        List<Digimon> digimons = new List<Digimon>();
        string[] lines = File.ReadAllLines(filePath);

        for (int i = 1; i < lines.Length; i++) // Starter på linje 1 (hopper over header)
        {
            string[] values = lines[i].Split(',');

            if (values.Length < 11) continue; // Sikrer at vi har nok verdier

            int number = int.TryParse(values[0], out int num) ? num : 0;
            string name = values[1];
            string stage = values[2];
            string type = values[3];
            string attribute = values[4];
            int memory = int.TryParse(values[5], out int mem) ? mem : 0;
            int equipSlots = int.TryParse(values[6], out int slots) ? slots : 0;
            int hp = int.TryParse(values[7], out int hpVal) ? hpVal : 0;
            int sp = int.TryParse(values[8], out int spVal) ? spVal : 0;
            int attack = int.TryParse(values[9], out int atk) ? atk : 0;
            int defense = int.TryParse(values[10], out int def) ? def : 0;
            int intelligence = int.TryParse(values[11], out int intel) ? intel : 0;
            int speed = int.TryParse(values[12], out int spd) ? spd : 0;

            digimons.Add(new Digimon(number, name, stage, type, attribute, memory, equipSlots, hp, sp, attack, defense, intelligence, speed));
        }

        return digimons;
    }
}
