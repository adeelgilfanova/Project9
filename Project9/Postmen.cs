using System;
namespace Project9
{
    class Postmen : IGame
    {
        public void Play(string[] commands)
        {
            Console.WriteLine("Игра *Почтальоны*");
            Console.WriteLine($"Команда '{commands[3]}' доставила больше всех писем");
        }
    }
}

