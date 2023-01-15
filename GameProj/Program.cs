using System;
using System.Collections.Generic;

namespace GameProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userList = new List<GameAccount>();
            var gameList = new List<BaseGame>();
            userList.Add(new GameAccount("user1"));
            userList.Add(new GameAccount("user2"));
            gameList.Add(new BaseGame(100, userList[0], userList[1]));
            gameList.Add(new BaseGame(50, userList[0], userList[1]));
            gameList.Add(new BaseGame(230, userList[0], userList[1]));
            gameList[0].WinSecondPlayer();
            gameList[1].WinFirstPlayer();
            gameList[2].WinSecondPlayer();
            Console.WriteLine("First player stat: ");
            foreach (var item in userList[0].GetStats())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\nSecond player stat: ");
            foreach (var item in userList[1].GetStats())
            {
                Console.WriteLine(item);
            }
        }
    }
}
