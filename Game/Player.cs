using System;

namespace card_game
{

    public class Player
    {
        bool isPlaying = true;
        public string _choice;
        public int _score;

        public Player()
        {
            _choice = "";
            _score = 300;
        }
        public void PlayerChoice()
        {
            while (isPlaying)
            {
                Console.WriteLine("Higher or Lower? [h,l]" );
                string _choice = Console.ReadLine();
            }
        }
    }


}