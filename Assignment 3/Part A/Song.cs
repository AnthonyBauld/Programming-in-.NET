using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Author: Anthony. Bauld
/// Date: October 27th, 2021
/// Statement of Authorship: I, Anthony. Bauld, certify that this material is my original work. No other person's work has been used without due acknowledgement.
/// </summary>

namespace Lab3A
{
    class Song : Media
    {
        // Creates a string with the name Album.
        public string Album { get; set; }
        // Creates a string with the name Artist.
        public string Artist { get; set; }
        // Creates a constructor that stores the variables title, year, album, and artist.
        public Song(string title, int year, string album, string artist) : base("", 0)
        {
            this.Title = title;
            this.Year = year;
            this.Album = album;
            this.Artist = artist;
        }
        // Creates a ToString() that will be used to format the data in the text file Data when it is invoked.
        public override string ToString()
        {
            // Returns the title, year, and album variables.
            return $"Song: {Title}, Year: {Year}, Album: {Album}, Artist: {Artist}" + "\n----------------------------";
        }
    }
}
