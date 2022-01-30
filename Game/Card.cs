using System;


namespace card_game
{   
    /// <summary>
    /// The responsibility of the card is to generate and hold the value
    /// of the card in a variable.
    /// </summary>
    public class Card
    {
        public int _value1 = 0;
        public int _value2 = 0;

        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>
        public Card()
        {  
        }
        
        ///<summary>
        /// Gets a random value for Card1
        ///</summary>
        public void GetNewCard()
        {
            Random random = new Random();
            _value1 = random.Next(1,14);
            Console.Write($"\nThe card is: {_value1}"); 
        }
        ///<summary>
        /// Gets a random value for Card2
        ///</summary>
        public void GetNextCard()
        {
            Random random = new Random();
            _value2 = random.Next(1,14);
            Console.Write($"\nThe next card is: {_value2}"); 
        }
    }

}    