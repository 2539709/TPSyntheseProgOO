namespace TPSyntheseProgOO
{
    class Warrior : Hero
    {
        public Warrior(int level) : base("Throd", StartingLifePoints, StartingStrengthPoints, level, StartingProtectionPoints)
        {
            
        }

        protected override int AttackDamage()
        {
            return StrengthPoints * Level;
        }

        protected override int DamageReceived(int damage)
        {
            return damage - ProtectionPoints;
        }


        private const int StartingLifePoints = 80;
        private const int StartingStrengthPoints = 10;
        private const int StartingProtectionPoints = 0;
        
    }
}
