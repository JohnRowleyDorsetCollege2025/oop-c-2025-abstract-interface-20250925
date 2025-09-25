// See https://aka.ms/new-console-template for more information
using oop_c_2025_abstract_interface_20250925.Models;

Console.WriteLine("Hello, World!");

//Animal animal = new Animal();

Dog dog = new Dog();
dog.Name = "Fido";
Cat cat = new Cat();
cat.Name = "Whiskers";
Console.WriteLine($"Dog's name: {dog.Name}");
Console.WriteLine($"Cat's name: {cat.Name}");

cat.Speak();
dog.Speak();
