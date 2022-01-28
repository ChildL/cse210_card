using System;
using System.Collections.Generic;

namespace card_game
{
    /// The Director starts the game
    public class Director
    {
        List<Card> cards = new List<Card>();
        bool isPlaying = true;
        int score = 300;

        /// Constructs a new instance of Director
        public Director()
        {
        
            /// sets up card1 and card2 in a list (this is the other way to get 2 cards)
            for (int i =0; i<2; i++)
            {
                Card card = new Card();
                cards.Add(card);
            }
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
            // foreach (Card card in cards)
            // {
            cards[0].GetNewCard();  
            // }      
        }
        public void DoUpdates() 
        {   
            Player player = new Player();
            string choice = player.PlayerChoice();
            cards[1].GetNewCard();

                
            choice = "";
            if ((cards[0]._value > cards[1]._value && choice == "h") 
            || (cards[0]._value < cards[1]._value && choice == "l"))
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