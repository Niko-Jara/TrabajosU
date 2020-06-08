using System;

namespace PracticaA
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente objCliente = new Cliente();          //Instantiate Object

            objCliente.nomCliente = "Jaimito";
            objCliente.ape1Cliente = "Jimenéz";
            objCliente.ape2Cliente = "Tenorio";
            objCliente.hablarPersona();
           
            do
            {

            } while (true);                              //Infinite cycle
        }
    }
}
