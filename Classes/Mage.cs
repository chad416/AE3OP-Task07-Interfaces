using InterfacesDemo.Interfaces;

namespace InterfacesDemo.Classes;

public sealed class Mage : ICombatant, IHealer
{
    public required string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public void Attack() =>
        Console.WriteLine($"{Name} casts a fireball for {AttackPower} damage.");

    public void Defend() => Console.WriteLine($"{Name} creates a magical barrier.");

    public void TakeDamage(int damage)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(damage);
        Health = Math.Max(0, Health - damage);
        Console.WriteLine($"{Name} takes {damage} damage. Current health: {Health}");
    }

    public void Heal(int hp)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(hp);
        Health += hp;
        Console.WriteLine($"{Name} recovered {hp} health. Current health: {Health}");
    }
}
