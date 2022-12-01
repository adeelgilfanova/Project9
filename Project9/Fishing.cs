using System;
namespace Project9
{
    class Fishing : IGame
    {
        public void Play(string[] commands)
        {
            Console.WriteLine("Игра *Рыбалка*");
            Console.WriteLine($"Команда {commands[1]} поймала самую большую рыбу");
        }
    }
}

