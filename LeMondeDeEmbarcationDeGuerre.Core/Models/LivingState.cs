﻿namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public class LivingState
    {
        private bool _value;

        public LivingState()
        {
            _value = true;
        }

        internal bool IsAlive()
        {
            return _value;
        }
    }
}