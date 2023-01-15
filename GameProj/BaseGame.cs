using System;

namespace GameProj
{
    public class BaseGame
    {
        private static int amount = 0;

        public int Id { get; private set; }

        private double rate;

        public double Rate 
        {
            get 
            {  
                return rate; 
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Rate can not be < 0");
                }
                rate = value;
            }
        }

        public GameAccount FirstPlayer { get; private set; }

        public GameAccount SecondPlayer { get; private set; }

        public BaseGame(double rate, GameAccount firstPlayer, GameAccount secondPlayer)
        {
            amount += 1;
            Id = amount;
            Rate = rate;
            FirstPlayer = firstPlayer;
            SecondPlayer = secondPlayer;
        }

        public void WinFirstPlayer()
        {
            FirstPlayer.WinGame(new GameResult(Id, Rate, SecondPlayer, Result.Win));
            SecondPlayer.LoseGame(new GameResult(Id, Rate, FirstPlayer, Result.Lose));
        }

        public void WinSecondPlayer()
        {
            FirstPlayer.LoseGame(new GameResult(Id, Rate, SecondPlayer, Result.Lose));
            SecondPlayer.WinGame(new GameResult(Id, Rate, FirstPlayer, Result.Win));
        }
    }
}
