using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_c_2025_abstract_interface_20250925.Models
{

    public interface IFlyable
    {
        public void Fly();
        public void Land();
    }


    internal abstract class Animal
    {
        // constructor to initialize name
        protected Animal(string name)
        {
           Name = name;
        }
        public string Name { get; set; } = string.Empty;

        public virtual void Describe() =>
            Console.WriteLine($"This is an animal named {Name}.");

        public abstract void Speak();
    }

    class Dog : Animal
    {
        // constructor to initialize name
        public Dog(string name) : base(name)
        {
            
        }
        public override void Speak()
        {
            Console.WriteLine("Woof!"); 
        }
    }

    class Wolf : Dog
    {
        // constructor to initialize name
        public Wolf(string name) : base(name)
        {
            
        }
        public override void Speak()
        {
            Console.WriteLine("Howl!");
        }
        public override void Describe() =>
            Console.WriteLine($"This is a wild animal named {Name}.");
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
            
        }
        public override void Speak()
        {
          Console.WriteLine("Meow!");
        }
    }

    class Bird : Animal, IFlyable
    {
        
        
    
        public Bird(string name) : base(name)
        {

        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }
        public void Land()
        {
            Console.WriteLine($"{Name} has landed.");
        }

        public override void Speak()
        {
            Console.WriteLine("chirp chirp");
        }
    }
}
