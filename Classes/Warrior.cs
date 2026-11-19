using InterfacesDemo.Interfaces;

namespace InterfacesDemo.Classes;

public sealed class Warrior : ICombatant
{
    public required string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public void Attack() =>
        Console.WriteLine($"{Name} attacks with a sword for {AttackPower} damage.");

    public void Defend() => Console.WriteLine($"{Name} raises a shield to defend.");

    public void TakeDamage(int damage)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(damage);
        Health = Math.Max(0, Health - damage);
        Console.WriteLine($"{Name} takes {damage} damage. Current health: {Health}");
    }
}
