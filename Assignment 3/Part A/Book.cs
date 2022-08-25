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
    /// <summary>
    /// Creates a class named book that will be used to access the data.txt file when a user calls upon books.
    /// </summary>
    class Book : Media
    {
        // Creates a string with the name Author.
        public string Author { get; set; }
        // Creates a string with the name Summary.
        public string Summary { get; set; }
        // Creates a constructor that stores the variables title, year, author, and summary.
        public Book(string title, int year, string author, string summary) : base("", 0)
        {
            this.Title = title;
            this.Year = year;
            this.Author = author;
            this.Summary = summary;
        }
        // Creates a ToString() that will be used to format the data in the text file Data when it is invoked.
        public override string ToString()
        {
            // Returns the title, year, and author variables.
            return $"Book: {Title}, Year: {Year}, Author: {Author}" + "\n----------------------------";
        }
    }
}
