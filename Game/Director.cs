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
        int totalscore = 300;
        /// Constructs a new instance of Director
        public Director()
        {
            /// sets up card1 and card2 in a list
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
                GetKeepPlaying();
                GetChoice();
                DoScore();
                
            
            }
        }   
    
        public void GetKeepPlaying()
        {
            Console.WriteLine("Play again? [y,n]" );
            string PlayCard = Console.ReadLine();
            isPlaying = (PlayCard == "y");
        }
        public void DoScore()
        {
            if (!isPlaying)
            {
                return;
            }
            score = 300;
            Player player = new Player();
            foreach (Card card in cards)
            {
                card.GetNewCard();
                {
                
                    
                }
                
            }


        }
    }
}