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

        public void Substract(LivingState livingState)
        {
            if(_value - 1 >= 0)
            {
                _value -= 1;
            }
            if(_value - 1 < 0)
            {
                livingState.Die();
            }
        }

        public void Add()
        {
            if(_value <= 0)
            {
                return;
            }
            if(_value + 1 <= 1000)
            {
                _value += 1;
            }
        }

        public void DisplayHealth()
        {
            Console.WriteLine("HP : " + _value.ToString());
        }
    }
}
