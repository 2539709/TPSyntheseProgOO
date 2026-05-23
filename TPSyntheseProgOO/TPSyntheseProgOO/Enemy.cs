namespace TPSyntheseProgOO
{
    abstract class Enemy : Character
    {
        protected Enemy(string name, string article, int lifePoints, int strengthPoints) : 
            base(name, lifePoints, strengthPoints)
        {
            _article = article;
        }

        public string Article { get { return _article; } }

        public string DefeatArticle { get { return _article == "le " ? "du " : "de " + _article; } }

        private readonly string _article;

    }
}
