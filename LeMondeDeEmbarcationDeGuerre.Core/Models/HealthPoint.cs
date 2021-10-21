namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public class HealthPoint
    {
        private int _value;

        public HealthPoint()
        {
            _value = 1000;
        }

        //Soustraction
        internal void Substract()
        {
            _value -= 1;
        }
    }
}
