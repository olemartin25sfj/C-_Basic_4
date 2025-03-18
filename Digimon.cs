class Digimon
{
    public int Number { get; set; }
    public string Name { get; set; }
    public string Stage { get; set; }
    public string Type { get; set; }
    public string Attribute { get; set; }
    public int Memory { get; set; }
    public int EquipSlots { get; set; }
    public int HP { get; set; }
    public int SP { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Intelligence { get; set; }
    public int Speed { get; set; }

    public Digimon(int number, string name, string stage, string type, string attribute, int memory, int equipSlots, int hp, int sp, int attack, int defense, int intelligence, int speed)
    {
        Number = number;
        Name = name;
        Stage = stage;
        Type = type;
        Attribute = attribute;
        Memory = memory;
        EquipSlots = equipSlots;
        HP = hp;
        SP = sp;
        Attack = attack;
        Defense = defense;
        Intelligence = intelligence;
        Speed = speed;
    }

    public override string ToString()
    {
        return $"{Number}: {Name} ({Stage}) - Type: {Type}, Attribute: {Attribute}, Memory: {Memory}, Attack: {Attack}, Speed: {Speed}";
    }
}
