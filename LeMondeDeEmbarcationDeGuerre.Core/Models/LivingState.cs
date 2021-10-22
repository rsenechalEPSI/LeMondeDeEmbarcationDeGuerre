using System;

namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public class LivingState
    {
        private bool _value;

        public LivingState()
        {
            _value = true;
        }

        public void DisplayState()
        {
            Console.WriteLine("Alive : " + _value);
        }
    }
}
