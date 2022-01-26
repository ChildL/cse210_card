using System;


namespace card_game
{
    public class Card
    {
        public int _value = 0;
        public string _choice = "";
        bool isPlaying = true;

        public Card()
        {
            
        }
        
        public void GetNewCard()
        
        {
            while (isPlaying)
            {
                Random random = new Random();
                _value = random.Next(1,14);
                Card card1 = new Card();
                Card card2 = new Card();
                int value1 = 0;
                int value2 = 0;
                {
                    card1._value = value1;
                    card2._value = value2;
                }
            }

        }

    }

}    