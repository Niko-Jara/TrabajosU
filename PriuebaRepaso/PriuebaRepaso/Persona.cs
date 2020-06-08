using System;
using System.Collections.Generic;
using System.Text;

namespace PriuebaRepaso
{
    class Persona
    {
        
        private string _Nombres;
        private string _Apellidos;
        private char  _Genero;

     
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
        public char Genero
        {
            get { return _Genero; }
            set { _Genero = value; }
        }
    }
}
