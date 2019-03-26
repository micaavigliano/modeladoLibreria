using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace ModeladoLibreria
{
    public class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("El Señor de los Anillos: El retorno del Rey", 5, "Tolkien", "J.R.R", "UK", 1, "fantasia", 3, "Minotauro", "España");
  
            Libro libro2 = new Libro("Game of Thrones: Hielo y Fuego", 6, "Martin", "George", "USA", 2, "fantasía", 4, "Plaza", "España");
           
            Libro libro3 = new Libro("Cien Años de Soledad", 9, "Gabriel", "Garcia Marquez", "Cuba", 3, "Novela", 5, "Debolsillo", "Argentina");

            Libro libro4 = new Libro("Los Años de Peregrinación del Chico sin Color", 10, "Murakami", "Haruki", "Japón", 4, "Novela", 6, "Tusquets", "Novela");

            List<Libro> Biblioteca = new List<Libro>();
            Biblioteca.Add(libro1);
            Biblioteca.Add(libro2);
            Biblioteca.Add(libro3);
            Biblioteca.Add(libro4);

            foreach (var libreria in Biblioteca)
            {
                Console.WriteLine("Libro: {0} \n El autor es: {1} {2} de {3} \n El genero es: {4} \n La editorial es: {5} \n", libreria.LibroNombre, libreria.AutorInfo.NombreAutor, libreria.AutorInfo.ApellidoAutor, libreria.AutorInfo.Pais, libreria.Generoinfo.TipoGenero, libreria.Editorial_info.NombreEditorial);
            }

            //Console.WriteLine("El libro se llama: {0} \n El autor es: {1} {2} de {3} \n El genero es: {4} \n La editorial es: {5} \n", libro1.LibroNombre, libro1.AutorInfo.NombreAutor, libro1.AutorInfo.ApellidoAutor, libro1.Generoinfo.TipoGenero, libro1.Editorial_info.NombreEditorial);
            //Console.WriteLine("El libro se llama: {0} \n El autor es: {1} {2} de {3} \n El genero es: {4} \n La editorial es: {5} \n", libro2.LibroNombre, libro2.AutorInfo.NombreAutor, libro2.AutorInfo.ApellidoAutor, libro2.Generoinfo.TipoGenero, libro2.Editorial_info.NombreEditorial);
            //Console.WriteLine("El libro se llama: {0} \n El autor es: {1} {2} de {3} \n El genero es: {4} \n La editorial es: {5} \n", libro3.LibroNombre, libro1.AutorInfo.NombreAutor, libro3.AutorInfo.ApellidoAutor, libro3.Generoinfo.TipoGenero, libro3.Editorial_info.NombreEditorial);
            //Console.WriteLine("El libro se llama: {0} \n El autor es: {1} {2} de {3} \n El genero es: {4} \n La editorial es: {5} \n", libro4.LibroNombre, libro4.AutorInfo.NombreAutor, libro4.AutorInfo.ApellidoAutor, libro4.Generoinfo.TipoGenero, libro4.Editorial_info.NombreEditorial);
            //Console.WriteLine("El libro se llama: {0} \n El autor es: {1} {2} de {3} \n El genero es: {4} \n La editorial es: {5} \n", libro4.LibroNombre, libro4.AutorInfo.NombreAutor, libro4.AutorInfo.ApellidoAutor, libro4.Generoinfo.TipoGenero, libro4.Editorial_info.NombreEditorial);

            Console.ReadKey();
        }
    }
}
