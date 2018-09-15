using System;

namespace Herencia {

    public class CD
    {
        private string Name {get;}

        public string Genre {get;}
        private int Year {get;}
        private string Artist {get;}
        private string[] Songs {get;}

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