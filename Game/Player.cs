using System;

namespace card_game
{
    /// <summary>
    /// <para> The player makes a choice if the card is high or low.</para>
    ///</summary>
        public class Player
    {
        public string _choice = "";

        /// <summary>
        /// Constructs a new instance of a player. 
        /// </summary>
        public Player()
        {
           
        }

        /// <summary>
        /// Gets the input from the player and stores the choice in a variable. 
        /// </summary>
        public string PlayerChoice()
        {    
            
            Console.Write("\nHigher or Lower? [h,l]  " );
            string _choice = Console.ReadLine();
            return _choice;   
             
        }
    }


}
