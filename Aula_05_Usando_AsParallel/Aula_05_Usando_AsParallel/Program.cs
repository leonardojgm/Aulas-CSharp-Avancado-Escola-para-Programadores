
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Aula_05_Usando_AsParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = Enumerable.Range(0, 10);

            var resultadoLista = 
                from n in lista.AsParallel()
                where BuscarNumeroPar(n)
                select n;

            Parallel.ForEach(resultadoLista, (i)=> 
            {
                System.Console.WriteLine(i);
            });

            System.Console.ReadKey();
        }

        private static bool BuscarNumeroPar(int n)
        {
            Thread.Sleep(1000);
            return n % 2 == 0;
        }
    }
}
