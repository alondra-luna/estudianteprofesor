
   public class Program
   {
       static void Main()
    {
        int numero;

        Console.WriteLine(" ingresar un numero");
        numero = int.Parse(GetReadKey());

        if (numero < 0)
            Console.WriteLine("el numero es: " + numero + "y su valor absoluto es: " + Math.Abs(numero));


        else

            Console.WriteLine("el numuro es: " + numero);


        Console.ReadKey();
    }

    private static object GetReadKey()
    {
        return Console.ReadKey;
    }
}

