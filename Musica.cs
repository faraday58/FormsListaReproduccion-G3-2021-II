using System;

namespace FormsListaReproduccion_G3_2021_II
{
    public class Musica
    {
        private string cancion;
        private string artista;
        private string album;

        public Musica(string cancion, string artista, string album)
        {
            Cancion = cancion;
            Artista = artista;
            Album = album;
        }

        public string Cancion { get => cancion; set => cancion = value; }
        public string Artista { get => artista; set => artista = value; }
        public string Album { get => album; set => album = value; }





    }
}
