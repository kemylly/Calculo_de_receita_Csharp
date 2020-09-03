using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesodobolo
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6, n7, n9, n10, n11, n12;
            string n8;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Calcular o peso do bolo.");
            Console.WriteLine("Digite o nome do seu bolo:");
            n8 = Console.ReadLine();
            Console.WriteLine("Qual a quantidade de farinha? (em gramas)");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de agua? (em ml)");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de leite? (em ml)");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de ovos? ");
            n4 = double.Parse(Console.ReadLine());
            Console.Clear();
            n5 = n4 * 35;
            n6 = n3 * 1.5;
            n7 = n1 + n2 + n6 + n5;
            n11 = n2 + n6;
            n9 = n11 * 0.1;
            n10 = n11 - n9;
            n12 = n10 + n1 + n5;
            Console.WriteLine("As quantidades em gramas usada no bolo: " + n8 + ", é " + n1 + "g + " + n2 + "g + " + n6 + "g + " + n5 + "g;");
            Console.WriteLine("O peso do seu bolo antes de assado era: " + n7 + "g.");
            Console.WriteLine("O peso final do bolo é: " + n12 + "g.");
            Console.ReadKey();
        }
    }
}
