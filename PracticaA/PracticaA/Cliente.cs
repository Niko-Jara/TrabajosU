using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaA
{
    class Cliente
    {
        string idCliente;                                      //Private property

        public string estIdcliente                             //Propiedad Privada
        {
            get { return this.idCliente; }
            set { this.idCliente = "1-1233-0817"; }
        }

        public string nomCliente { get; set; }                 //Public property
         
        public string ape1Cliente { get; set; }

        public string ape2Cliente { get; set; }

        public void  hablarPersona()
        {

            Console.WriteLine("Hola" + idCliente + nomCliente + ape1Cliente + ape2Cliente);
        }
    }
}
