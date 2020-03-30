using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_for_7
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
              começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.*/
 

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i+" "+"Quadrado "+(Math.Pow(i,2))+" "+"Cubo "+(Math.Pow(i,3)));

            }
            Console.WriteLine(n+" linhas");
            Console.WriteLine("3 colunas");
        }
    }
}
