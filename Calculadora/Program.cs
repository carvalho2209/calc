using System;

namespace Calculadora
{
    public class Program 
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora();

            Console.WriteLine("Qual a largura do cômodo?");
            calculadora.Largura = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("Qual a profundidade do cômodo?");
            calculadora.Profundidade = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("A área das Paredes é: ");
            
            calculadora.CalcularAreaParedes(calculadora.Largura, calculadora.Profundidade);
            Console.WriteLine(calculadora.AreaParedes);

            Console.WriteLine("A área do teto é: ");
            calculadora.CalcularAreaTeto(calculadora.Largura, calculadora.Profundidade);
            Console.WriteLine(calculadora.AreaTeto);

            Console.WriteLine("A litragem de tinta necessária é:");
            Console.WriteLine(calculadora.CalcularLitragemNecessaria());

            Console.ReadLine();
        }
    }
}
