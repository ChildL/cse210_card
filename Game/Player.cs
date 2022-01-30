using System;

namespace card_game
{
    /// still deciding if I am going to have a class player 
    public class Player
    {
        public string _choice = "";

        public Player()
        {
           
        }
        public string PlayerChoice()
        {    
            
            Console.Write("\nHigher or Lower? [h,l]  " );
            string _choice = Console.ReadLine();
            return _choice;   
             
        }
    }


}
