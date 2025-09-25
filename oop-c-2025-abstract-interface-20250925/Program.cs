// See https://aka.ms/new-console-template for more information
using oop_c_2025_abstract_interface_20250925.Models;

Console.WriteLine("Hello, World!");

// Animal animal = new Animal();

Dog dog = new Dog("Fido");
Cat cat = new Cat("Whiskers");
Wolf wolf = new Wolf("Ghost");
Bird bird = new Bird("Birdie");


Console.WriteLine($"Dog's name: {dog.Name}");
Console.WriteLine($"Cat's name: {cat.Name}");

cat.Speak();
dog.Speak();
wolf.Speak();
bird.Speak();


dog.Describe();
cat.Describe();
wolf.Describe();
bird.Describe();

bird.Fly();
bird.Land();
