using System;
using System.Collections.Generic;
using System.Text;

namespace ModeladoLibreria
{
    public class Genero
    {
        private int generoId;
        private string tipoGenero;

        public int Genero_ID
        {
            set { generoId = value; }
            get { return generoId; }
        }

        public string TipoGenero
        {
            set { tipoGenero = value; }
            get { return tipoGenero; }
        }
    }
}
