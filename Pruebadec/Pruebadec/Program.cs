//EJERCICIOS DE NIKOL JARA 

using System;

namespace Pruebadec
{
    class Program
    {
        private static void suma()
        {
            int num = 1;
            int nume = 2;
            int resp = num + nume;

            Console.WriteLine("Este es el resultado dela suma" + resp);
        }
        private static void stayhome() {

            string yourname;
            Console.WriteLine("Por favor escriba su nombre");
            yourname = Console.ReadLine();

            Console.WriteLine("Bienvenido {0}", yourname);
        }

        private static void ocational()
        {
            int edad;
            Console.WriteLine("Por favor ingresa tu edad");
            edad = Convert.ToInt32(Console.ReadLine());             // para convertir valores 
               
            switch (edad)
            {
                case 1:
                    if (edad > 18)
                    {
                        Console.WriteLine("Eres menor de edad");
                    }
                    break;
                case 2:
                    if (edad >= 18)
                    {
                        Console.WriteLine("Eres mayor de edad");
                    }
                    break;
                default:                                          // este default es cuando inguno de los cases coinciden 
                    Console.WriteLine("Eres mayor de edad");
                    break;
            }
        }
        public static void entrada(int x, int y)
        {
            int resp = x / y;
            Console.WriteLine("Este es una prueba de entrada del main",resp);
        }
        public static int Area(int h, int w)
        {
            return h * w;
        }
        static void Sqr(int s)
        {
            s  *= s;
            Console.WriteLine("Este es una prueba de entrada del main", s);
        }

        //Metodo del mismo nombre diferentes parametros

        static void Print(int a)
        {
            Console.WriteLine("Value:" + a);
        }
        static void Print(double a)
        {
            Console.WriteLine("Value:" + a);
        }
        static void Print(string label, double a )
        {
            Console.WriteLine(label + a);
        }

        //Metodo del mismo nombre diferentes parametros
        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.WriteLine("");
                }
                for (int k = 1; k <=2 * i - 1; k++)
                {
                    Console.WriteLine("*" + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program.suma();                                       //como es que se  declarar variables desde acá
            Program.stayhome();
            Program.ocational();
            Program.entrada(42,45);
            Program.entrada(72, 48);                              //puedo invocar un metodo tantas veces como quiera
            int res = Area(h: 5, w: 8);
            Console.WriteLine(res);
            int s = 3;
            Program.Sqr(s);                                       //Otra manera de declarar variables desde aca //ref y out *
            Program.Print(11);
            Program.Print(4.13);
            Program.Print("Average: ", 7.57);
            Program.DrawPyramid(5);
        }

     
    }
}
