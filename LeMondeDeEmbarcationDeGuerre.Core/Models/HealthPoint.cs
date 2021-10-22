using System;

namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public class HealthPoint
    {
        private int _value;

        public HealthPoint()
        {
            _value = 1000;
        }

        internal void Substract()
        {
            _value -= 1;
        }

        internal void Add()
        {
            _value += 1;
        }
    }
}
