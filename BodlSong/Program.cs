using System;

namespace BodlSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 99; i > 1; i--)

            {
                if (i != 1)
                {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.\nTake one down and pass it around {i - 1} bottles of beer on the wall");

                }

                else
                {
                    Console.WriteLine($"{i} bottle of beer on the wall, {i}bottle of beer.\n take one down and pass it around no more bottles of beer");
                }
                }
                Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer. Go to the store and buy some more, 99 bottles of beer on the wall.");
            }
        }
    }


    


