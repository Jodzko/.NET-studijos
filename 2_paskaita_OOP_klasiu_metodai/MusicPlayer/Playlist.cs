using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_paskaita_OOP_klasiu_metodai.MusicPlayer
{
    internal class Playlist
    {
        List<Song> SongsInPlaylist { get; set; }

        public Playlist()
        {
            SongsInPlaylist = new List<Song>();
        }

        public void AddSong(string name, string author, double length)
        {
            SongsInPlaylist.Add(new Song(name, author, length));
        }
        public void RemoveSong(string name, string author, double length)
        {
            SongsInPlaylist.Remove(new Song(name, author, length));
        }

        public void ReviewPlaylist()
        {
            foreach (var song in SongsInPlaylist)
            {
                Console.WriteLine($"{song.Name} {song.Author} {song.Length}");
            }
        }
    }
}
