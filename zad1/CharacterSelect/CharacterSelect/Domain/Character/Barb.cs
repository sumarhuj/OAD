using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public class Barb : Entity.Character
{
    public Barb(string name) : base(name, CharacterClass.Barb)
    {
        Health = 20;
        Strength = 20;
        Intelligence = 5;
        Agility = 8;
        AttackSpeed = 10;
    }
}