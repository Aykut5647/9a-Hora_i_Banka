using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Kak se kazsas? ");
                person.name = Console.ReadLine();
                Console.WriteLine("Na kolko godini si? ");
                person.age = int.Parse(Console.ReadLine());
                Console.WriteLine("Kude jiveesh? ");
                person.grad = Console.ReadLine();
                person.GetHashCode();
                Console.WriteLine($"{person.name},{person.age},{person.grad}");
                if (person.grad == "Sopot")
                {
                    Console.WriteLine($"{person.name} e ot Sopot");


                }
                else
                {
                    Console.WriteLine("Nqma e sopotnenec.");
                }
            }
        }
    }
}
