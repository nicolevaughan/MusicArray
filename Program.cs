using System;
using System.Linq.Expressions;

namespace MusicArray
{
    class Program
    {


        enum Genre
        {
            Grunge,
            Country,
            ClassicRock,
            Pop,
            Indie
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }

            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }

            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }


            static void Main(string[] args)
            {
                //Song song=new Song();
                Console.WriteLine("How many songs would you like to enter?");
                int size = int.Parse(Console.ReadLine());

                Music[] collection = new Music[size];

                try
                {
                    for (int i = 0; i < size; i++)
                    {

                        Console.WriteLine("What is the title of your favorite song?");
                        collection[i].setTitle(Console.ReadLine());
                        Console.WriteLine("What is name of the artist that performs the song?");
                        collection[i].setArtist(Console.ReadLine());
                        Console.WriteLine("What is the name of the album that contains the song?");
                        collection[i].setAlbum(Console.ReadLine());
                        Console.WriteLine("What is the length of the song?");
                        collection[i].setLength(Console.ReadLine());
                        Console.WriteLine("What is the genre?");
                        Console.WriteLine("G - Grunge\nC - Country\nR - Classic Rock\nP - Pop\nI - Indie");
                        Genre tempGenre = Program.Genre.Grunge;
                        char g = char.Parse(Console.ReadLine());
                        switch (g)
                        {
                            case 'G':
                                tempGenre = Program.Genre.Grunge;
                                break;
                            case 'C':
                                tempGenre = Program.Genre.Country;
                                break;
                            case 'R':
                                tempGenre = Program.Genre.ClassicRock;
                                break;
                            case 'P':
                                tempGenre = Program.Genre.Pop;
                                break;
                            case 'I':
                                tempGenre = Program.Genre.Indie;
                                break;
                        }
                        collection[i].setGenre(tempGenre);
                    }
                }


                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }
                /*Song song = new Song(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);

                Song newSong = song;

                newSong.setTitle("Vampire");
                newSong.setLength("3 minutes");
                Console.WriteLine("Here's song #2");
                Console.WriteLine($"{newSong.Display()}");

                Console.WriteLine($"Here's song #1");
                Console.WriteLine($"{song.Display()}");*/


            }
        }
    }
}