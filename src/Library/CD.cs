using System;

namespace Herencia {

    public class CD
    {
        public string Name {get;}

        public string Genre {get;}
        public int Year {get;}
        public string Artist {get;}
        public string[] Songs {get;}

        /// <summary>
        /// Método para crear un objeto de tipo CD.
        /// </summary>
        /// <param name="name">Título del disco.</param>
        /// <param name="genre">Género del disco</param>
        /// <param name="year">Año de publicación.</param>
        /// <param name="artist">Artista del disco.</param>
        /// <param name="songs">Listado con los títulos de las canciones.</param>
        public CD(string name, string genre, int year, string artist, string[] songs)
        {
            this.Name = name;
            this.Genre = genre;
            this.Year = year;
            this.Artist = artist;
            this.Songs = songs;
        }

    }
}