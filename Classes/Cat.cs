using InterfacesDemo.Interfaces;

namespace InterfacesDemo.Classes;

public sealed class Cat : IAnimal
{
    public void Speak() => Console.WriteLine("Meow!");
}
