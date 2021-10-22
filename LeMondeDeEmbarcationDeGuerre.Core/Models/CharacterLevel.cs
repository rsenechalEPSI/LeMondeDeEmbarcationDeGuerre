using System;

namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public class CharacterLevel
    {
        private int _level;

        public CharacterLevel()
        {
            _level = 1;
        }

        public void DisplayLevel()
        {
            Console.WriteLine("Level : " + _level);
        }
    }
}
