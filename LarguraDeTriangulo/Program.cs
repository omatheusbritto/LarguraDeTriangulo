// Fazer um programa para ler os valores da largura e altura  de um retângulo. Em seguida,
// mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe como mostrado
// no projeto ao lado.

using Course;
using System;
using System.Globalization;

namespace LarguraDeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x;
            x = new Triangulo();
            Console.WriteLine("Entre com o lado A");
            x.A = Double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o lado B");
            x.B = Double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o lado C");
            x.C = Double.Parse(Console.ReadLine());
            Console.WriteLine(x);

        }
    }
}