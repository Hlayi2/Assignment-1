using System;

namespace ConsoleApp13

{
    //Creating a class
    class MilkSong
    {
        //Method to sing the MilkSong
        public void sing()
        {
            //Loop statement
            for (int bottles = 99; bottles > 0; bottles--)
            {
                if (bottles > 1)
                {
                    Console.WriteLine($"{bottles} bottles of milk on the wall,{bottles} bottles of milk.Take one down and pass it around,\n");
                }
                else
                {
                    Console.WriteLine($"1 bottle of milk on the wall, 1 bottle of the milk.Take one down and pass it around\n");
                }
            }
        }
    }
    // Main program class
    public class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of MiklSong

            MilkSong song = new MilkSong();
            song.sing();
        }
    }
}







