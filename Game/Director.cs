using System;
using System.Collections.Generic;

namespace card_game
{
    ///<summary>
    /// The Director starts the game
    ///</summary>
    public class Director
    {
        
        bool isPlaying = true;
        int score = 300;
        int card1;
        int card2;
        string choice;

        /// Constructs a new instance of Director
        public Director()
        {
        
        }

        public void StartGame()
        {
            while (isPlaying)
            {   
                DoInputs();
                DoUpdates();
                DoOutputs();
            }
        }   
    
        public void DoInputs()
        {
            Card card = new Card();
            card.GetNewCard();
            card1 = card._value1;    
                 
        }
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