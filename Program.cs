using System;
using System.Collections.Generic;

namespace meuAppDotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg1 = "Alo Mundo do dotnet no linux!!! ;-)";
            Console.WriteLine(msg1);
            Console.WriteLine($"A Hora atual é {DateTime.Now}");
            Console.WriteLine($"A mensagem 1 possui {msg1.Length} letras.");

            var result = msg1.Contains("Mundo");
            Console.WriteLine(result);

            int a = 12;
            int b = 3;
            Console.WriteLine(a+b);

            int sum = 0;
            for(int i=1; i<=20; i++){
                if(i % 3 == 0){
                    sum += i;
                }
            }
            Console.WriteLine($"The value of sum is {sum}.");

            var nomes = new List<string> {"name", "Willian", "Isaias", "Maria"};

            foreach(string nome in nomes){
                Console.WriteLine($"Hello {nome.ToUpper()}");
            }

            var fibonacciNumbers = new List<int> {1,1};

            while(fibonacciNumbers.Count < 20){
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
            }

            foreach(int n in fibonacciNumbers){
                Console.WriteLine(n);
            }
        }
    }
}
