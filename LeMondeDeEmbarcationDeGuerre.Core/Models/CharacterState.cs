namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public class CharacterState
    {
        private HealthPoint _healthPoint;
        private LivingState _livingState;

        public CharacterState()
        {
            _healthPoint = new HealthPoint();
            _livingState = new LivingState();
        }

        internal void SubstractDamage(Damage damage)
        {
            damage.Substract(_healthPoint);
        }
    }
}
