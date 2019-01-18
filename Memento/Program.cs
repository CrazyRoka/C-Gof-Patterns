using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while (!game.IsFinished)
            {
                game.Play();
                if (game.IsOver)
                {
                    game.Load();
                }
                else
                {
                    if (!game.IsFinished)
                        game.Save();
                }
            }
        }
    }
}
