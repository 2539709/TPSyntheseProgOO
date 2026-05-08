namespace TPSyntheseProgOO
{
    abstract class Enemy
    {
        protected Enemy(string name, int lifePoints, int strengthPoints)
        {
            _name = name;
            _lifePoints = lifePoints;
            StrenghtPoints = strengthPoints;
        }

        protected int StrenghtPoints { get; }

        private readonly string _name;
        private readonly int _lifePoints;
        
    }
}
