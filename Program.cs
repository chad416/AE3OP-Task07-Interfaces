using InterfacesDemo.Classes;
using InterfacesDemo.Interfaces;

Console.WriteLine("Animals");
IAnimal[] animals = [new Dog(), new Cat()];
foreach (IAnimal animal in animals)
{
    animal.Speak();
}

Console.WriteLine("\nCombatants");
ICombatant[] fighters =
[
    new Warrior { Name = "Aragorn", Health = 100, AttackPower = 25 },
    new Mage { Name = "Merlin", Health = 80, AttackPower = 40 }
];

foreach (ICombatant fighter in fighters)
{
    fighter.Attack();
    fighter.Defend();
}

fighters[0].TakeDamage(10);

if (fighters[1] is IHealer healer)
{
    healer.Heal(30);
}

Console.WriteLine("\nExplicit interface implementation");
Knight knight = new();
((IAttack)knight).Attack();
((IDefend)knight).Attack();
