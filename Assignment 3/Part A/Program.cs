using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Anthony. Bauld
/// Date: October 27th, 2021
/// Purpose: The purpose of the program is to sort data based on the media type (Book, Movie, or Song) and display them in whichever order the user selects.
/// Statement of Authorship: I, Anthony. Bauld, certify that this material is my original work. No other person's work has been used without due acknowledgement.
/// </summary>

namespace Lab3A
{
    class Program
    {
        private static readonly Media[] media;

        /// <summary>
        /// Creates a program that reads data from a text file named Data.txt and presents it in three different arrays: Book, Movies, and Songs.
        /// </summary>
        /// <param name="args">The arg parameter is used to send a variable string to a function's many arguments.</param>
        static void Main(string[] args)
        {
            // If the data retrieved from string[] is empty, this if statement runs.
            if (args is null)
            {
                // If the data in Data.txt is empty or not found, this method returns an exception.
                throw new ArgumentNullException(nameof(args));
            }
            // Creates the array, which keeps the data from the Data.text file and may be accessed when the user tries to find a string.
            _ = new ISearchable[100];
            // Creates an array called BookArray which stores the book text from Data.txt.
            var BookArray = new List<Media>()
            {
                new Book("The Fellowship of the Ring", 1954, "J.R.R. Tolkien", ""),
                new Book("The Two Towers", 1954, "J.R.R. Tolkien", ""),
                new Book("The Return of the King", 1955, "J.R.R. Tolkien", ""),
                new Book("The Andromeda Strain",1969,"Michael Crichton",""),
                new Book("Of Mice and Men",1937,"John Steinbeck",""),
                new Book("The Hitchhiker's Guide to to the Glasxy", 1979, "Douglas Adams", ""),
                new Book("To Kill a Mockingbird", 1960, "Harper Lee", ""),
                new Book("Nineteen Eighty-Four", 1949, "George Orwell", ""),
                new Book("American Gods", 2001, "Neil Gaiman", ""),
                new Book("The Anubis Gates", 1983, "Tim Powers", "")
            };
            // Creates an array called MovieArray which stores the book text from Data.txt.
            var MovieArray = new List<Media>()
            {
                new Movie("The Princess Bride", 1987,"The Rolling Stones", ""),
                new Movie("The Shawshank", 1994,"Frank Darabont", ""),
                new Movie("The Adventures of Buckaroo Banzai Across the 8th Dimension ", 1984,"W.D. Richter", ""),
                new Movie("Twelve Monkeys", 1995,"Terry gilliam", ""),
                new Movie("The Usual Suspects", 1995,"Bryan Singer", ""),
                new Movie("Mystery Men", 1995,"Kinka Usher", ""),
                new Movie("12 Angry Men", 1999,"Kinka Usher", ""),
                new Movie("Mystery Men", 1957,"Sidney Lumet", ""),
                new Movie("North By Northwest", 1959,"Alfred Hitchcock", ""),
                new Movie("Big Trouble in Little China", 1986,"john Carpenter", ""),
                new Movie("The Godfather", 1972,"Francis Ford Coppola", ""),
            };
            // Creates an array called SongArray which stores the book text from Data.txt.
            var SongArray = new List<Media>()
            {
                new Song("Unforgettable", 1991, "Unforgettable... With Love", "Natalie Cole & Nat King Cole"),
                new Song("Paint it Black", 1966, "Aftermath", "The Rolling Stones"),
                new Song("Baba O'Riley", 1971, "who's Next", "The Who"),
                new Song("Stairway to Heaven", 1971, "Led Zepplein IV", "Led Zeppelin"),
                new Song("Paradise by the Dashboard Light", 1977, "Bat out of Hell", "Meat Loaf"),
                new Song("Hotel California", 1976, "Hotel California", "Eagles"),
                new Song("Kiss and Tell", 1987, "Bete Noire", "Bryan Ferry"),
                new Song("People Are Strange", 1967, "Strange Days", "The Doors"),
                new Song("Go Your Own Way", 1976, "Rumours", "Fleetwood Mac"),
            };
            // Creates the choice string, which will be used to make a switch.
            String choice;
            // Creates a while loop for the Menu.
            while ((choice = Menu()) != "6")
                // Creates a switch loop that allows users to select from 1 through 6,
                // as well as list and exit the program displaying the stored media (Books, Movies, and Songs).
                switch (choice)
                {
                    case "1":
                        {
                            // Creates a foreach method that calls the BookArray(b) in order.
                            foreach (Book b in BookArray)
                            {
                                // Prints the BookArray text from the Media List.
                                Console.WriteLine(b);
                            }
                            break;
                        }
                    case "2":
                        {
                            // Creates a foreach method that calls the MovieArray(m) in order.
                            foreach (Movie m in MovieArray)
                            {
                                // Prints the MovieArray text from the Media List.
                                Console.WriteLine(m);
                            }
                            break;
                        }
                    case "3":
                        {
                            // Creates a foreach method that calls the SongArray(s) in order.
                            foreach (Song s in SongArray)
                            {
                                // Prints the SongArray text from the Media List.
                                Console.WriteLine(s);
                            }
                            break;
                        }
                    case "4":
                        {
                            // Creates a foreach method that calls the BookArray(b) in order.
                            foreach (var b in BookArray)
                            {
                                // Prints the BookArray text from the Media List.
                                Console.WriteLine(b);
                            }
                            // Creates a foreach method that calls the MovieArray(m) in order.
                            foreach (var m in MovieArray)
                            {
                                // Prints the MovieArray text from the Media List.
                                Console.WriteLine(m);
                            }
                            // Creates a foreach method that calls the SongArray(s) in order.
                            foreach (var s in SongArray)
                            {
                                // Prints the SongArray text from the Media List.
                                Console.WriteLine(s);
                            }
                            break;
                        }
                    case "5":
                        {
                            // Creates an if statement that allows the user to search a string using ISearchable if the case "5" is selected.
                            if (choice == "5")
                            {
                                // Prints text prompting the user to choose a string from which to search the media.
                                Console.Write("\nEnter a string to Search media: \n");
                            }
                            break;
                        }
                    case "6":
                        {
                            // Exit the program when the user picks "6".
                            break;
                        }
                }
        }

        /// <summary>
        /// This generates the "Menu" stactic string, which prints the lines that allow the user to choose selections from the displayed menu.
        /// </summary>
        /// <returns>After the console has finished printing the menu, it returns the readline.</returns>
        private static String Menu()
        {
            // Writes a Menu within the console displaying text outputs the user can choose from.
            // The color cyan is used to change the color of the title console output.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Anthony's Media Collection");
            Console.WriteLine("==========================");
            // The color white is used to change the color of the menu console output.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. List All Books");
            Console.WriteLine("2. List All Movies");
            Console.WriteLine("3. List All Songs");
            Console.WriteLine("4. List All Media");
            Console.WriteLine("5. Search All Media by Title");
            Console.WriteLine("\n6. Exit Program");
            Console.Write("\nEnter Choice: ");
            // Returns the next line outputs and display's them within the console
            return Console.ReadLine();
        }

        /// <summary>
        /// Creates a static Media ReadData() function that reads the data from the bin folder's Data.txt file.
        /// </summary>
        /// <param name="data">The parameter data is used to access the text file that is stored in the bin folder.</param>
        /// <returns>If StreamReader fails to read anything from the Data.txt file, it returns null.</returns>
        public static Media[] ReadData(string data)
        {
            // Creates a try statement that creates a that will be checked for mistakes while it runs.
            try
            {
                // Pulls the data from the Data.txt file that's placed within the bin folder.
                StreamReader DataText = new StreamReader(data);
            }
            // Creates a catch statement that executes this code if the try block fails.
            catch (Exception)
            {
                Console.WriteLine("There is a problem with the file.");
            }
            // After a successful attempt and/or catch, Media is returned.
            return null;
        }

        /// <summary>
        /// Allows the book data type and class to be searched from within the main program.
        /// </summary>
        /// <param name="media">The media class's search data is retrieved.</param>
        /// <param name="i">Creates the I int, which will be used to count the amount of data in the book.</param>
        /// <param name="data">Reads the data from the text file Data.</param>
        /// <param name="exploded">This function creates a string variable that will be utilized in the book function constructor.</param>
        public static void ReadBook(ISearchable[] media, ref int i, StreamReader data, string[] exploded)
        {
            // If the data retrieved from StreamReader is empty, this if statement runs.
            if (data is null)
            {
                // If the data in Data.txt is empty or not found, this method returns an exception.
                throw new ArgumentNullException(nameof(data));
            }
            // Creates a string called summary.
            string Summary = "";
            // Create's a Book object with 4 properties (The second property "Year" being converted using the Parese Method).
            media[i] = new Book(exploded[1], int.Parse(exploded[2]), exploded[3], Summary);
            // Increase i by one.
            i++;
        }

        /// <summary>
        /// Allows the movie data type and class to be searched from within the main program.
        /// </summary>
        /// <param name="media">The media class's search data is retrieved.</param>
        /// <param name="i">Creates the I int, which will be used to count the amount of data in the movie.</param>
        /// <param name="data">Reads the data from the text file Data.</param>
        /// <param name="exploded">This function creates a string variable that will be utilized in the movie function constructor.</param>
        public static void ReadMovie(ISearchable[] media, int i, StreamReader data, string[] exploded)
        {
            // If the data retrieved from StreamReader is empty, this if statement runs.
            if (data is null)
            {
                // If the data in Data.txt is empty or not found, this method returns an exception.
                throw new ArgumentNullException(nameof(data));
            }

            // Creates a string called summary.
            string Summary = "";
            // Create's a Movie object with 4 properties (The second property "Year" being converted using the Parese Method).
            media[i] = new Movie(exploded[1], int.Parse(exploded[2]), exploded[3], Summary);
        }

        /// <summary>
        /// Allows the song data type and class to be searched from within the main program.
        /// </summary>
        /// <param name="media">The media class's search data is retrieved.</param>
        /// <param name="i">Creates the i int, which will be used to count the amount of data in the song.</param>
        /// <param name="data">Reads the data from the text file Data.</param>
        /// <param name="exploded">This function creates a string variable that will be utilized in the song function constructor.</param>
        public static void ReadSong(ISearchable[] media, ref int i, StreamReader data, string[] exploded)
        {
            // If the data retrieved from StreamReader is empty, this if statement runs.
            if (data is null)
            {
                // If the data in Data.txt is empty or not found, this method returns an exception.
                throw new ArgumentNullException(nameof(data));
            }
            // Creates a string called summary.
            string Summary = "";
            // Create's a Song object with 4 properties (The second property "Year" being converted using the Parese Method).
            media[i] = new Song(exploded[1], int.Parse(exploded[2]), exploded[3], Summary);
            // Increase i by one.
            i++;
        }
    }
}
