using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Hero
    {
        private static Random generator = new Random();
        private int _lives = 10;
        private int _level = 5;
        private Game _game;
        public Hero(Game game) => _game = game;

        public void Fight()
        {
            int random = generator.Next(0, 5);
            if (random < 3)
            {
                _lives--;
                Console.WriteLine("Hero was damaged!");
                
            }
            else if(random == 3)
            {
                _level++;
                Console.WriteLine("Hero received new level!");
            }
            else
            {
                _level++;
                _lives++;
                Console.WriteLine("Hero found a treasure! Level and lives increased");
            }

            Console.WriteLine($"Remains {_lives} health points");
            Console.WriteLine($"Current level = {_level}");
            if (_lives == 0)
            {
                Console.WriteLine("GAME OVER");
                _game.IsOver = true;
            }
            if (_level == 100)
            {
                Console.WriteLine("Congratulation! You won!");
                _game.IsFinished = true;
            }
        }

        public HeroMemory SaveState()
        {
            return new HeroMemory(_lives, _level);
        }

        public void LoadState(HeroMemory memory)
        {
            _lives = memory.Lives;
            _level = memory.Level;
            Console.WriteLine($"Loaded! Lives = {_lives}. Level = {_level}");
        }
    }
}
