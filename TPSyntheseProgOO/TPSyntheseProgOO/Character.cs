namespace TPSyntheseProgOO
{
    abstract class Character
    {
        protected Character(string name, int lifePoints, int strengthPoints)
        {
            Name = name;
            _lifePoints = lifePoints;
            MaxLifePoints = lifePoints;
            _strengthPoints = strengthPoints;
        }

        public string Name { get; }
        public int LifePoints { get { return _lifePoints; } }
        public int StrengthPoints { get { return _strengthPoints; } }
        public int MaxLifePoints { get; }


        protected abstract int AttackDamage();

        protected abstract int DamageReceived(int damage);


        // Les attributs
        private int _lifePoints;
        private int _strengthPoints;

    }
}
