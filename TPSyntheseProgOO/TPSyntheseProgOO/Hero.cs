namespace TPSyntheseProgOO
{
    abstract class Hero
    {
        protected Hero(string name, int level, int lifePoints, int strenghtPoints, int protectionPoints)
        {
            _name = name;
            Level = level;
            _lifePoints = lifePoints;
            StrengthPoints = strenghtPoints;
            _protectionsPoints = protectionPoints;
        }

        protected int StrengthPoints { get; }

        protected int Level { get; }

        abstract protected int AttackDamage();

        abstract protected int DamageReceived();


        private readonly string _name;
        private readonly int _lifePoints;
        private readonly int _protectionsPoints;

    }
}
