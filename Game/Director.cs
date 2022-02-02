using System;
using System.Collections.Generic;

namespace card_game
{
    ///<summary>
    /// <para> The Director starts the game</para> 
    ///<para> The responsibility of a Director is to control the sequence of play.</para> 
    ///</summary>
    public class Director
    {
        
        bool isPlaying = true;
        int score = 300;
        int card1;
        int card2;
        string choice;

        /// <summary>
        /// Constructs a new instance of Director
        /// </summary>
        public Director()
        {
        
        }
        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {   
                DoInputs();
                DoUpdates();
                DoOutputs();
            }
        }   
        /// <summary>
        ///  <para>Creates the object card with new value.</para>
        /// </summary>
        public void DoInputs()
        {
            Card card = new Card();
            card.GetNewCard();
            card1 = card._value1;    
                 
        }

        /// <summary>
        /// <para>Creates the player object and gets choice higher or lower.</para>
        /// <para>
        /// Creates the second card object with a value.</para>
        ///<para> 
        /// Compares the values of the cards and the choice and assigns points accordingly.
        /// </para>
        /// </summary>
        public void DoUpdates() 
        {   
            Player player = new Player();
            string choice = player.PlayerChoice();
           
            
            Card card = new Card();
            card.GetNextCard();
            card2 = card._value2; 
           
           
            if ((card1 < card2 && choice == "h") 
            || (card1 > card2 && choice == "l"))
            {
                score += 100;
                
            }   
            else
            {
                score -= 75;
            }  
        }   

        ///<summary> 
        ///<para>Gets user choice to play again</para>
        ///<para>Displays the score.</para>
        ///</summary>
        public void DoOutputs()
        {  
            if (!isPlaying)
            {   
                return;
            }     
            
            Console.WriteLine($"\nYour score is: {score}");
            Console.Write("\nPlay again? [y,n]  " );
            string PlayCard = Console.ReadLine();
            isPlaying = (PlayCard == "y" && score >0);
        }   
           
    }
}