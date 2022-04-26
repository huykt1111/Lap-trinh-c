using System;

namespace Animal_NguyenQuangHuy
{
    class Animal
    {
        public void eat()
        {
            Console.WriteLine(" Animal is eat. . .");
        }
        public void makeSound()
        {
            Console.WriteLine(" Animal is makeSound. . .");
        }

        public virtual void run()
        {

        }
        public virtual void fly()
        {

        }
    }
    class Cat : Animal
    {
        public override void run()
        {
            Console.WriteLine(" Cat is run. . .");
        }
    }
    class Bird : Animal
    {
        public override void fly()
        {
            Console.WriteLine(" Bird is fly. . .");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Animal cat224 = new Cat();
            Animal bird224 = new Bird();
            cat224.run();
            bird224.fly();
        }
    }
}
