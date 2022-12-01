using System;
namespace Project9
{
    class Sea : IGame
    {
        public void Play(string[] commands)
        {
            Console.WriteLine("Игра *Море*");
            Console.WriteLine($"Команда '{commands[3]}'дольше всех продержалась под водой");
        }
    }
}

