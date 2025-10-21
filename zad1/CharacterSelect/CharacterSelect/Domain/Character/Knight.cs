using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public class Knight : Entity.Character
{
    public Knight(string name) : base(name, CharacterClass.Barb)
    {
        Health = 25;
        Strength = 15;
        Intelligence = 5;
        Agility = 8;
        AttackSpeed = 10;
    }
}