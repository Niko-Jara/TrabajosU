using System;
using System.Collections.Generic;
using System.Text;

namespace Presentacion6
{
    public class Clientes                         //CTRL + R, E keyboard to display the Encapsulate Field dialog box.
    {
        private int _idCliente;
        private string _Nombres;
        private string _Apellidos;

        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }
        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

    }
}
