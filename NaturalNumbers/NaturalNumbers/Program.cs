using System;

namespace NaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Digite um número:");
                    string number = Console.ReadLine();
                    int total = Soma(int.Parse(number));
                    Console.WriteLine("A soma dos múltiplos de 3 e 5 é: " + total);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Número inválido.");
            }

        }

        public static int Soma(int number)
        {
            int a = 0;

            for(var i = 0; i <= number; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    a += i;
                }
            }

            return a;
        }
    }
}
