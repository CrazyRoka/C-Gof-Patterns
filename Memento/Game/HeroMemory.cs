using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class HeroMemory
    {
        public int Lives { get; }
        public int Level { get; }
        public HeroMemory(int lives, int level)
        {
            Lives = lives;
            Level = level;
        }
    }
}
