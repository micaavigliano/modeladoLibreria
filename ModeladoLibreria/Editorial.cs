using System;
using System.Collections.Generic;
using System.Text;

namespace ModeladoLibreria
{
    public class Editorial
    {
        private int editorialID;
        private string nombreEditorial;
        private string paisEditorial;

        public int EditorialID
        {
            set { editorialID = value; }
            get { return editorialID; }
        }

        public string NombreEditorial
        {
            set { nombreEditorial = value; }
            get { return nombreEditorial; }
        }

        public string PaisEditorial
        {
            set { paisEditorial = value; }
            get { return paisEditorial; }
        }
    }
}
