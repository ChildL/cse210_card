using System;


namespace card_game
{
    public class Card
    {
        public int _value = 0;

        public Card()
        {  
        }
        
        public void GetNewCard()
        {
            Random random = new Random();
            _value = random.Next(1,14);
            Console.Write($"\nThe card is: {_value}"); 
        }
        public void GetNextCard()
        {
            Random random = new Random();
            _value = random.Next(1,14);
            Console.Write($"\nThe next card is: {_value}"); 
        }
    }

}    