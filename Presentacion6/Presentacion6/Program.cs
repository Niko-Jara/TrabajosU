using System;

namespace Presentacion6
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientesVentas Cliente;
            Cliente = new ClientesVentas();
            Cliente.IdCliente = 123;
            Console.WriteLine("Ingresa tus Apellidos");
            Cliente.Apellidos = Console.ReadLine();
            Cliente.Nombres = "Marcos";
            Cliente.RFC = "HENN";
            Cliente.Direccion = "av tigre 110";
            Cliente.Colonia = "La cueva del jaguar";
            Cliente.Municipio = "tuxla gutierrez";
            Cliente.EsCredito = true;
            Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia + " " + Cliente.Municipio);
            Console.WriteLine(Cliente.Apellidos + " " + Cliente.RFC);
            if (Cliente.EsCredito)
            {
                Console.WriteLine("El cliente tiene credito");
            }
            else 
            {
                Console.WriteLine("El cliente no tine credito");
            }
            Console.ReadKey();
        }
    }
}
