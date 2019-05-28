using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluacion
{
    class Billetera
    {

        public int gastar { get; set; }
        public int dinero { get; set; }
        public int ahorro { get; set; }
        public int Gastar()

        {

            
            Console.WriteLine("ingrese el dinero inicial");
            dinero = Convert.ToInt32(Console.ReadLine());

          
            Console.WriteLine($"el dinero que posee es {dinero}");
            Console.ReadLine();
            Console.WriteLine("¿cuanto dinero desea gastar? ");
            gastar = Convert.ToInt32(Console.ReadLine());

            


            if (gastar>dinero)
            {
                Console.WriteLine("no puede gastar mas de lo que posee");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"puede gastarlo menos el ahorro {gastar*0.1/100}");
                


            }
            return dinero;

        }
       
        public int Depositar()
        {
            
            Console.WriteLine("desea depositar todo su dinero en el banco?");
            var resp = Console.ReadLine();
           int resta = dinero - dinero;
            if (resp =="si")
            {
                Console.WriteLine("su dinero ha sido depositado en el banco");
                Console.WriteLine($"la billetera contiene {resta} ");
                 Console.ReadLine();
              

            }
            if (resp == "no")
            {
                Console.WriteLine("su dinero no ha sido depositado en el banco");
                Console.ReadLine();
            }
           
            



            return dinero;
        }
        public int ImprimirDinero()
        {
            Console.WriteLine("dinero actual que hay en la billetera mostrando el deposito en el banco?");
            var resp=Console.ReadLine();
            int resta = dinero - dinero;
            if (resp=="si")
            {
                Console.WriteLine($"la billetera contiene {dinero-gastar} ");
                Console.ReadLine();

            }
            if(resp=="no")
            {
                double interes = gastar * 0.1 / 100;
                Console.WriteLine($"dinero que actualmente tiene en la billetera{dinero - gastar + interes}");
                Console.ReadLine();
            }
           
            return dinero;
        }
        public void NotificarTransaccion()
        {

        }
        public void TotalAhorrado()
        {

        }
    }
}
