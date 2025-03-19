public class Digimon
{
    public int Number { get; set; }
    public string Name { get; set; }
    public string Stage { get; set; }
    public string Type { get; set; }
    public string Attribute { get; set; }
    public int Memory { get; set; }
    public int EquipSlots { get; set; }
    public int Lv50HP { get; set; }
    public int Lv50SP { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Intelligence { get; set; }
    public int Speed { get; set; }



    public override string ToString()
    {
        return $"{Number}: {Name} ({Stage}) - Type: {Type}, Attribute: {Attribute}, Memory: {Memory}, Atk: {Attack}, Def: {Defense} Spd: {Speed}";
    }
}
