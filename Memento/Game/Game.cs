using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Game
    {
        private Hero _hero;
        private HeroMemory _state;
        public bool IsOver { get; set; }
        public bool IsFinished { get; set; }
        public Game()
        {
            Console.WriteLine("Starting new game...");
            Console.WriteLine();
            _hero = new Hero(this);
            _state = _hero.SaveState();
        }

        public void Play()
        {
            if (IsOver || IsFinished) throw new Exception("Start new game, please");
            Console.WriteLine("Playing the game");
            _hero.Fight();
            Console.WriteLine();
        }

        public void Save()
        {
            Console.WriteLine("Saving game");
            _state = _hero.SaveState();
        }

        public void Load()
        {
            Console.WriteLine("Loading game");
            _hero.LoadState(_state);
            IsOver = IsFinished = false;
        }
    }
}
