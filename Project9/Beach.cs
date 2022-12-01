using System;
namespace Project9
{
    class Beach : IGame
    {
        public void Play(string[] commands)
        {
            Console.WriteLine("Игра *Пляж*");
            Console.WriteLine($"Команда '{commands[0]}' добралась первой");

        }
    }
}

