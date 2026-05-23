namespace TPSyntheseProgOO
{
    class Assassin : Enemy
    {
        public Assassin() :
            base ("assassin", "l'", StartingLifePoints, StartingStrengthPoints)
        {
            
        }

        protected override int AttackDamage()
        {
            int chance = _random.Next(100);
            if (chance < 30)
            {
                return StrengthPoints + StrengthPoints / 5;
            }
            else
            {
                return StrengthPoints;
            }
        }

        protected override int DamageReceived(int damage)
        {
            int esquive = _random.Next(100);
            if (esquive < 30)
            {
                damage = 0;
            }
            return damage;
        }

        

        private const int StartingLifePoints = 40;
        private const int StartingStrengthPoints = 20;
        private readonly Random _random = new Random();
    }
}
