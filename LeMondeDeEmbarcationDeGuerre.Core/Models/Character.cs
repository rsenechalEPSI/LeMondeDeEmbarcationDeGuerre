namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public class Character
    {
        private CharacterLevel _characterLevel;
        private CharacterState _characterState;
        
        public Character()
        {
            _characterLevel = new CharacterLevel();
            _characterState = new CharacterState();
        }


        public void Attack(Character char2)
        {
            char2.TakeDamage(new Damage());
        }

        internal void TakeDamage(Damage damage)
        {
            _characterState.SubstractDamage(damage);

        }
    }
}
