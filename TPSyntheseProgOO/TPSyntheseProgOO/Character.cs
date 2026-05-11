namespace TPSyntheseProgOO
{
    abstract class Character
    {
        protected Character(string name, int lifePoints, int strengthPoints)
        {
            Name = name;
            LifePoints = lifePoints;
            MaxLifePoints = lifePoints;
            StrengthPoints = strengthPoints;
        }

        public string Name { get; }
        public int LifePoints { get; private set; }
        public int StrengthPoints { get; private set; }
        public int MaxLifePoints { get; }


        protected abstract int AttackDamage();

        protected abstract int DamageReceived(int damage);

    }
}
