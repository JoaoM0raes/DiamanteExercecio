using System;
namespace DiamanteExercecio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linhas = 0;
            Console.WriteLine("Escreva o número de linhas");
            linhas = Convert.ToInt32(Console.ReadLine());
            int tamanho = (linhas - 1) / 2;
            int espaços = (linhas - 1) / 2;
            int a = 1;

            for (int i = 0; i < tamanho; i++)
            {
                for (int j =0; j <espaços; j++)               
                    Console.Write(" ");                  
                for (int j = 0; j<a; j++)                
                    Console.Write("x");
                a+=2;
                espaços--;
                Console.Write("\n");
            }
            for (int i = linhas; i > 0; i--)
            {
                for (int k = 0; k < espaços; k++)                
                    Console.Write(" ");                
                for (int j = 0; j < a; j++)                
                    Console.Write("x");                
                a -= 2;
                espaços++;
                Console.Write("\n");
            }
        }
    }
}
