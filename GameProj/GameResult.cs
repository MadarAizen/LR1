using System;

namespace GameProj
{
    public class GameResult
    {
        public int GameId { get; private set; }

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

        public GameAccount Opponent { get; private set; }

        public Result Result { get; private set; }

        public GameResult(int gameId, double rate, GameAccount opponent, Result result)
        {
            GameId = gameId;
            Rate = rate;
            Opponent = opponent;
            Result = result;
        }

        public override string ToString()
        {
            return "GameId: " + GameId + ".\nRate: " + Rate + ".\nOpponent: " + Opponent + ". Result: " + Result;
        }
    }
}
