using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_paskaita_OOP_klasiu_metodai.MusicPlayer
{
    internal class Song
    {
        public string Name { get; set; }

        public string Author { get; set; }
        public double Length { get; set; }

        public Song(string name, string author, double length)
        {
            Name = name;
            Author = author;
            Length = length;
        }
    }
}
