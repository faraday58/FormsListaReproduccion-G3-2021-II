using System;
using System.Collections.Generic;

namespace LibrosG3
{
    class Program
    {
        static void Main()
        {
            Libro novela;

            novela.titulo = "50 sombras";
            novela.autor = "E. L. James ";
            novela.tpaginas = 500;           
            

            Console.WriteLine(" El libro a presentar es:  ");
            Console.WriteLine(" Título: {0}  \n Autor: {1} \n Número de páginas: {2}  ",novela.titulo,novela.autor,novela.tpaginas  );



            Libro[] novelas = new Libro[2];
            /*
                        for(int i=0; i < novelas.Length; i++)
                        {
                            Console.WriteLine("Ingresa el título de la novela: ");
                            novelas[i].titulo = Console.ReadLine();
                            Console.WriteLine("Ingresa el autor de la novela: ");
                            novelas[i].autor = Console.ReadLine();
                            Console.WriteLine("Ingresa el número de páginas de la novela: ");
                            novelas[i].tpaginas = short.Parse(Console.ReadLine());

                        }


                        for (int i = 0; i < novelas.Length; i++)
                        {

                            Console.WriteLine(" El libro a presentar es:  ");
                            Console.WriteLine(" Título: {0}  \n Autor: {1} \n Número de páginas: {2}  ", novelas[i].titulo, novelas[i].autor, novelas[i].tpaginas);

                        }
            */


            for (int i = 0; i < 5; i++)
            {
                dias diasemana = dias.Lunes + i;

                Console.WriteLine("El día de hoy es : {0} ",(int) diasemana);
            }


            List<string> titulosLibros = new List<string>();

            titulosLibros.Add("Cien años de soledad");
            titulosLibros.Add("El capitán no tiene quien le escriba  ");
            titulosLibros.Add("El laberinto de la soledad");

            foreach(string titulo in   titulosLibros )
            {
                Console.WriteLine(titulo);
            }


            Console.ReadLine();
        }
    }
}
