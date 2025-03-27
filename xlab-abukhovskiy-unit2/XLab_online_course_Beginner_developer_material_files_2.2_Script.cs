using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program1
    {
        class House
        {
            public string street;
            public int number;

            public void Print()
            {
                Console.WriteLine($"{street}, {number}");
            }
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int c = 10;
            if (b > a)
            {
                Console.WriteLine($"Число {b} больше числа {a}");
            }
            else if (b < a)
            {
                Console.WriteLine($"Число {b} меньше числа {a}");
            }
            else
            {
                Console.WriteLine($"Число {b} равно числу {a}");
            }

            Console.WriteLine('\n');

            for (int j = 1; j < 10; j++)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine('\n');

            int i = 0;
            while (i <= 10)
            {
                i++;
                Console.WriteLine(i);
            }

            Console.WriteLine('\n');

            int[] numbers = new int[5];
            int[] numbers2 = { 5, 6, 7, 8, 9 };
            numbers2[4] = 15;
            Console.WriteLine(numbers2[4]);

            Console.WriteLine('\n');

            void Helloworld()
            {
                Console.WriteLine("Hello World");
            }
            void Sum(int a1, int b1)
            {
                int sum = a1 + b1;
                Console.WriteLine(sum);
            }

            void Human(string name, int age)
            {
                Console.WriteLine($"Человек по имени {name}, возраст - {age}");
            }
            Helloworld();
            Human("Алексей", 25);

            Console.WriteLine('\n');

            House tower = new House();
            tower.street = "Красная";
            tower.number = 50;
            tower.Print();
        }
    }
}
