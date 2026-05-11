namespace TPSyntheseProgOO
{
    class Potion : Item
    {
        public Potion(string name, string article, int lifePoints) :
            base(name, article)
        {
            _lifePoints = lifePoints;
        }

        public int LifePoints { get { return _lifePoints; } }

        private readonly int _lifePoints;
    }
}
