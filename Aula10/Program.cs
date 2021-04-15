using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula10, Calcule a Diagonal do Losango, tipo double
            //Jonas Valereo - Técnico em Informática 

            //Declarando as variaveis tipo double

            double d, D, area;


            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite valor diagonal menor: ");
            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor diagonal maior: ");
            D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();


            //Declarando a variavel area do losango

            area = (d * D) / 2;


            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine("Valor da Diagonal: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Parabén, tente de novo!!!");

            // saida da aplicação, console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do progama

        }
    }
}
