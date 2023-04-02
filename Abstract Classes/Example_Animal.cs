using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    // Animal animal = new Animal(); - Error
    // tu mchirdeba rom mqondes saerto velebi Name, Age, da aseve minda rom MakeSound metodi yvela shvilobil klasshi mqondes gansxvavebuli
    public abstract class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public abstract void MakeSound();
        }


      public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Woof!");
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow!");
            }
        }
    
}
