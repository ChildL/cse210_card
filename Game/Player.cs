using System;

namespace card_game
{
    /// still deciding if I am going to have a class player 
    public class Player
    {
        public string choice = "";

        public Player()
        {
           
        }
        public string PlayerChoice()
        {    
            
            Console.Write("\nHigher or Lower? [h,l]  " );
            string choice = Console.ReadLine();
            return choice;    
        }
    }


}
