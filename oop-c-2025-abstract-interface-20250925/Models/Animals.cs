using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_c_2025_abstract_interface_20250925.Models
{
    internal abstract class Animal
    {
        public string Name { get; set; }    = string.Empty;

        public abstract void Speak();
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            ///throw new NotImplementedException();
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
          ///  throw new NotImplementedException();
        }
    }
}
