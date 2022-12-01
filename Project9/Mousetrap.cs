using System;
namespace Project9
{
    class Mousetrap : IGame
    {
        public void Play(string[] commands)
        {
            Console.WriteLine("Игра *Мышеловка*");
            Console.WriteLine($"Команда '{commands[2]}' поймала мышь");
        }
    }
}

