namespace TPSyntheseProgOO
{
    class Archer : Hero
    {
        public Archer(int level) : base("Elwena", StartingLifePoints, StartingStrengthPoints, level, StartingProtectionPoints)
        {
            
        }

        protected override int AttackDamage()
        {
            int attaque = _random.Next(StrengthPoints / 2, StrengthPoints + StrengthPoints / 2 + 1 );
            return attaque;
        }

        protected override int DamageReceived(int damage)
        {
            return damage - ProtectionPoints;
        }


        private const int StartingLifePoints = 50;
        private const int StartingStrengthPoints = 10;
        private const int StartingProtectionPoints = 0;
        private Random _random = new();
    }

}
