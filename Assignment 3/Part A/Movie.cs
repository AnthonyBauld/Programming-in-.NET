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
    class Movie : Media
    {
        // Creates a string with the name Director.
        public string Director { get; set; }
        // Creates a string with the name Summary.
        public string Summary { get; set; }
        // Creates a constructor that stores the variables title, year, director, and summary.
        public Movie(string title, int year, string director, string summary) : base("", 0)
        {
            this.Title = title;
            this.Year = year;
            this.Director = director;
            this.Summary = summary;
        }
        // Creates a ToString() that will be used to format the data in the text file Data when it is invoked.
        public override string ToString()
        {
            // Returns the title, year, and director variables.
            return $"Movie: {Title}, Year: {Year}, Director: {Director}" + "\n----------------------------";
        }
    }
}
