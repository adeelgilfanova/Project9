using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project9

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствуем вас на шоу *Большие Гонки*\nВсего 4 команды, каждая из них сыграет в игру!");
            string[] name_commands = { "Россия", "Франция", "Китай", "Украина" };
            Commands commands = new Commands(name_commands);
            commands.PlayGame(new Beach());
            commands.PlayGame(new Fishing());
            commands.PlayGame(new Mousetrap());
            commands.PlayGame(new Postmen());
            commands.PlayGame(new Sea());
            commands.PlayGame(new Slide());
            commands.PlayGame(new MyGame());
            Console.ReadKey();
        }
    }
}