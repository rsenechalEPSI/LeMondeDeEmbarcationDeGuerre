using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public interface ICharacter
    {
        public void Attack(Character characterToHit);
        public void Heal(Character characterToHeal);

        
    }
}
