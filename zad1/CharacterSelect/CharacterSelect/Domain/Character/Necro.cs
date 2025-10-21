using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public class Necro : Entity.Character
{
    public Necro(string name) : base(name, CharacterClass.Necro)
    {
        Health = 15;
        Strength = 4;
        Intelligence = 25;
        Agility = 10;
        SummonSpeed = 10;
    }
}

    
