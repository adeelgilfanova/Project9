using System;
namespace Project9
{
    class Slide : IGame
    {
        public void Play(string[] commands)
        {
            Console.WriteLine("Игра *Горка*");
            Console.WriteLine($"Команда '{commands[1]}' быстрее всех прошла испытание");
        }
    }
}

