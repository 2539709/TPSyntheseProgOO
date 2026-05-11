namespace TPSyntheseProgOO
{
    class Weapon : Item
    {
        public Weapon(string name, string article, int strengthPoints) :
            base(name, article)
        {
            _strengthPoints = strengthPoints;
        }

        public int StrengthPoints { get { return _strengthPoints; } }

        private readonly int _strengthPoints;
    }
}
