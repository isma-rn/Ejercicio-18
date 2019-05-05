using System;

namespace E18_NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[] { 1, 2, 3, 4, 5};
            foreach(int v in valores)            
                Console.WriteLine("{0}, {1} primo", v, EsPrimo(v)? "es":"no es" );
            
            Console.WriteLine("números primos menores a 100");
            for (int i = 0; i<=100; i++)
                if(EsPrimo(i))
                    Console.Write("{0} ", i);
            Console.ReadLine();
        }
        public static bool EsPrimo( int n )
        {
            if (n > 1)
            {
                int contador = 0;
                for (int i = 1; i <= n; i++)                
                    if (n % i == 0)
                        contador++;
                
                if (contador == 2)
                    return true;
            }            
            return false;
        }
    }
}
