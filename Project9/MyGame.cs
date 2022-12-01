using System;
namespace Project9
{
    class MyGame : IGame
    {
        public void Play(string[] commands)
        {
            Console.WriteLine("Игра *Покер*");
            Console.WriteLine($"Команда '{commands[2]}' выиграла партию у команды '{commands[3]}'");
        }
    }
}

