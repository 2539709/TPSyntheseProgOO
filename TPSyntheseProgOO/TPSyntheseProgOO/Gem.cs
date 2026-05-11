namespace TPSyntheseProgOO
{
    class Gem : Item
    {
        public Gem(string name, string article, int magicPoints) : 
            base(name, article)
        {
            _magicPoints = magicPoints;
        }

        public int MagicPoints { get { return _magicPoints; } }

        private readonly int _magicPoints;
    }
}
