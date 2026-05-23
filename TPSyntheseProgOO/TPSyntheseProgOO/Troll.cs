namespace TPSyntheseProgOO
{
    class Troll : Enemy
    {
        public Troll() : base ("Un troll", StartingLifePoints, StartingStrengthPoints )
        {
            
        }

        protected override int AttackDamage()
        {
            return StrengthPoints;
        }

        protected override int DamageReceived(int damage)
        {
            if (damage < 15)
            {
                damage = 0;
            }
            return damage;
        }
        

        private const int StartingLifePoints = 80;
        private const int StartingStrengthPoints = 10;
    }
}
