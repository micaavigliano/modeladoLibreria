using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Text;

namespace ModeladoLibreria
{
    public class Libro
    {
        private string libroNombre;
        private int libroID;
        private Autor autorInfo;
        private Genero generoInfo;
        private Editorial editorialInfo;

        public string LibroNombre
        {
            set { libroNombre = value; }
            get { return libroNombre; }
        }

        public int LibroID
        {
            set { libroID = value; }
            get { return libroID; }
        }

        public Autor AutorInfo
        {
            set { autorInfo = value; }
            get { return autorInfo; }
        }

        public Genero Generoinfo
        {
            set { generoInfo = value; }
            get { return generoInfo; }
        }

        public Editorial Editorial_info
        {
            set { editorialInfo = value; }
            get { return editorialInfo; }
        }

        public Libro(string nombreLibro, int L_ID, string nombre_Autor, string apellidoAutor, string autorPais, int generoID, string genero, int EditID, string nombreEditorial, string paisEdit)
        {
            LibroNombre = nombreLibro;
            LibroID = L_ID;
            AutorInfo = new Autor();
            AutorInfo.NombreAutor = nombre_Autor;
            AutorInfo.ApellidoAutor = apellidoAutor;
            AutorInfo.Pais = autorPais;
            generoInfo = new Genero();
            generoInfo.Genero_ID = generoID;
            generoInfo.TipoGenero = genero;
            editorialInfo = new Editorial();
            editorialInfo.EditorialID = EditID;
            editorialInfo.NombreEditorial = nombreEditorial;
            editorialInfo.PaisEditorial = paisEdit;
        }


    }
}
