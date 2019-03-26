using System;
using System.Collections.Generic;
using System.Text;

namespace ModeladoLibreria
{
    public class Autor
    {
        private string nombreAutor;
        private string apellidoAutor;
        private string pais;

        public string NombreAutor
        {
            set { nombreAutor = value; }
            get { return nombreAutor; }
        }

        public string ApellidoAutor
        {
            set { apellidoAutor = value; }
            get { return apellidoAutor; }
        }

        public string Pais
        {
            set { pais = value; }
            get { return pais; }
        }
    }
}
