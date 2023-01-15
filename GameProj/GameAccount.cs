using System;
using System.Collections.Generic;

namespace GameProj
{
    public class GameAccount
    {
        private static int amount = 0;

        public int Id { get; private set; }

        public string UserName { get; private set; }

        private double currentRating;

        public double CurrentRating
        {
            get 
            {
                return currentRating;
            }
            private set
            {
                if(value < 1)
                {
                    throw new ArgumentException("Rate can not be < 1");
                }
                currentRating = value;
            }
        
        }

        public int GamesCount { get; private set; }

        private List<GameResult> GameResults;

        public GameAccount(string userName)
        {
            GameResults = new List<GameResult>();
            Id = ++amount;
            UserName = userName;
            CurrentRating = 1;
            GamesCount = 0;
        }

        public void WinGame(GameResult result)
        {
            GamesCount++;
            CurrentRating += result.Rate;
            GameResults.Add(result);
        }

        public void LoseGame(GameResult result)
        {
            GamesCount++;
            if (CurrentRating - result.Rate >= 1)
            {
                CurrentRating -= result.Rate;
            }
            else
            {
                CurrentRating = 1;
            }
            GameResults.Add(result);
        }

        public List<GameResult> GetStats()
        {
            return GameResults;
        }

        public override string ToString()
        {
            return "Id: " + Id + ". UserName: " + UserName + ". CurrentRating: " + CurrentRating + ". GamesCount: " + GamesCount;
        }
    }
}
