using System;

namespace Animal_NguyenQuangHuy
{
    class Program
    {
        class Animal
        {
            public  void  eat()
            {
                Console.WriteLine(" Animal is eat. . .");
            }
            public  void makeSound()
            {
                Console.WriteLine(" Animal is makeSound. . .");
            }
        }
        class Cat : Animal
        {
            public void run()
            {
                Console.WriteLine(" Cat is run. . .");
            }
        }
        class Bird : Animal
        {
            public void fly()
            {
                Console.WriteLine(" Bird is fly. . .");
            }
        }
        static void Main(string[] args)
        {
            Animal cat224 = new Cat();
            Animal bird224 = new Bird();
            cat.;
        }
    }
}
