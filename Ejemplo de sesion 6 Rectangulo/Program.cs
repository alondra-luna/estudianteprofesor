using System;

namespace PerimetroAreaYDiagonalDeUnRectangulo
{
    class PerimetroAreaYDiagonalDeUnRectangulo
    {
        static void Main(string[] args)
        {
            double area, diagonal, lado_mayor, lado_menor, perimetro;
            Console.Write("Ingresa el valor de lado mayor: ");
            lado_mayor = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de lado menor: ");
            lado_menor = double.Parse(Console.ReadLine());
            perimetro=lado_menor*2+lado_mayor*2;
            area=lado_menor*lado_mayor;
            diagonal=Math.Sqrt(lado_menor*lado_menor+lado_mayor*lado_mayor);
            Console.WriteLine("Valor de area: " + area);
            Console.WriteLine("Valor de diagonal: " + diagonal);
            Console.WriteLine("Valor de perimetro: " + perimetro);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}