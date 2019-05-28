using System;

namespace Evaluacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Billetera metod = new Billetera();
            int opcion = metod.Gastar();
            int deps = metod.Depositar();
            int impr = metod.ImprimirDinero();
           
           
        }
    }
}
