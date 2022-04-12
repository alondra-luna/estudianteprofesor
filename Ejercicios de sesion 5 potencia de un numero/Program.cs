using System;
 
public class test
{
    static void Main(string[] args)
    {
        int baseNumber, expNumber, result, contador;
        Console.Write("Base del numero : ");
        baseNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Exponente : ");
        contador = expNumber = Convert.ToInt32(Console.ReadLine());
 
        result = 1;
        while (contador != 0) {
            result *= baseNumber;
            --contador;
        }
 
        Console.WriteLine("Exponer {1} veces el numero {2} da un resultado de {3}", expNumber, baseNumber, result);
 
        Console.ReadLine();
    }
}