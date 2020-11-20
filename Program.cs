using System;

namespace sequenciaSentena
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1; 
            while (numero <= 100)
            {
                Console.Write(numero);
                Console.Write(" ");
                numero += 1; 
            }
                Console.WriteLine("\nPara encerrar, pressione qualquer tecla"); 
                Console.ReadLine(); 
        }
 
    }
}
