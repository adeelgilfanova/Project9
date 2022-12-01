using System;
namespace Project9
{
    class Commands
    {
        private string[] name;
        public Commands(string[] name)
        {
            this.name = name;
        }
        public void PlayGame(IGame game)
        {
            game.Play(name);
        }
    }
}

