using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public static class CsvReader
{
    public static List<Digimon> ReadCsv(string filePath)
    {
        var digimons = new List<Digimon>();
        var lines = File.ReadAllLines(filePath).Skip(1);

        foreach (var line in lines)
        {
            var parts = line.Split(',');
            if (parts.Length < 13) continue;

            if (!int.TryParse(parts[0], out int number) ||
                !int.TryParse(parts[5], out int memory) ||
                !int.TryParse(parts[6], out int equipSlots) ||
                !int.TryParse(parts[7], out int lv50HP) ||
                !int.TryParse(parts[8], out int lv50SP) ||
                !int.TryParse(parts[9], out int attack) ||
                !int.TryParse(parts[10], out int defense) ||
                !int.TryParse(parts[11], out int intelligence) ||
                !int.TryParse(parts[12], out int speed))
                continue;

            digimons.Add(new Digimon
            {
                Number = number,
                Name = parts[1],
                Stage = parts[2],
                Type = parts[3],
                Attribute = parts[4],
                Memory = memory,
                EquipSlots = equipSlots,
                Lv50HP = lv50HP,
                Lv50SP = lv50SP,
                Attack = attack,
                Defense = defense,
                Intelligence = intelligence,
                Speed = speed,
            });
        }
        return digimons;
    }
}
