namespace TPSyntheseProgOO
{
    class Orc : Enemy
    {
        public Orc() : 
            base("orque", "l'", StartingLifePoints, StartingStrengthPoints)
        {
            
        }
        protected override int AttackDamage()
        {
            int attackDamage =  StrengthPoints * LifePoints / MaxLifePoints;
            return attackDamage;
        }

        protected override int DamageReceived(int damage)
        {
            return damage;
        }

        private const int StartingLifePoints = 50;
        private const int StartingStrengthPoints = 10;

    }
}
