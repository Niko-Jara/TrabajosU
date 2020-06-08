using System;

namespace PriuebaRepaso
{
    class Program
    {
        private static void Operaciones() 
        {
            Console.WriteLine("Que operación matemática desea realizar 1:Suma 2:Resta 3:Dividir 4:Modulo");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int suma;
            int resta;
            int dividir;
            double modulo;

            switch (num)
            {
                case 1:
                    if (num == 1)
                    {
                        suma = num1 + num2;
                        Console.WriteLine("Resultado de la suma es:" + suma);
                    }
                    break;
                case 2:
                    if (num == 2)
                    {
                        resta = num1 - num2;
                        Console.WriteLine("Resultado de la resta es:" + resta);
                    }
                    break;
                case 3:
                    if (num == 3)
                    {
                        dividir = num1 / num2;
                        Console.WriteLine("Resultado de la división es:" + dividir);
                    }
                    break;
                case 4:
                    if (num == 4)
                    {
                        modulo = num1 % num2;
                        Console.WriteLine("Resultado del cociente es:" + modulo);
                    }
                    break;
                default:
                    Console.WriteLine("No digitaste un número válido");
                    break;
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Persona objpersona = new Persona();

                Console.WriteLine("Ingrese su Nombre");
                objpersona.Nombres = Console.ReadLine();
                Console.WriteLine("Ingrese sus Apellidos");
                objpersona.Apellidos = Console.ReadLine();
                Console.WriteLine("Ingrese su Genero Femenino 'F' y Masculino 'M'");
                objpersona.Genero = Convert.ToChar(Console.ReadLine());
                Program.Operaciones();

                if (objpersona.Genero == 'F' || objpersona.Genero == 'f')
                {
                    Console.WriteLine("Que le vaya muy bien Sr." + objpersona.Nombres);
                }
                else
                {
                    Console.WriteLine("Que le vaya muy bien Sr." + objpersona.Nombres);
                }
                Console.WriteLine("-------PARA SALIR OPRIMA S--------");

            } while (Console.ReadKey(true).Key != ConsoleKey.S);
        }
    }
}
