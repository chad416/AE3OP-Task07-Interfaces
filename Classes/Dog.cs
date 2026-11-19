using InterfacesDemo.Interfaces;

namespace InterfacesDemo.Classes;

public sealed class Dog : IAnimal
{
    public void Speak() => Console.WriteLine("Woof!");
}
