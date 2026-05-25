namespace TPSyntheseProgOO
{
    /// <summary>
    /// Classe abstraite représentant un ennemi du donjon
    /// </summary>
    abstract class Enemy : Character
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name">Le nom de l'ennemi</param>
        /// <param name="article">L'article défini associé au nom (ex: "l'", "le ")</param>
        /// <param name="indefiniteArticle">L'article indéfini associé au nom (ex: "un ", "une ")</param>
        /// <param name="lifePoints">Les points de vie de départ</param>
        /// <param name="strengthPoints">Les points de force de départ</param>
        protected Enemy(string name, string article, string indefiniteArticle, int lifePoints, int strengthPoints) : 
            base(name, lifePoints, strengthPoints)
        {
            _article = article;
            _indefiniteArticle = indefiniteArticle;
        }

        /// <summary>
        /// L'article défini associé au nom de l'ennemi
        /// </summary>
        public string Article { get { return _article; } }

        /// <summary>
        /// L'article indéfini associé au nom de l'ennemi
        /// </summary>
        public string IndefiniteArticle { get { return _indefiniteArticle; } }

        /// <summary>
        /// Retourne l'article contracté avec "de" pour le message de défaite
        /// </summary>
        public string DefeatArticle { get { return _article == "le " ? "du " : "de " + _article; } }

        // Attribut
        private readonly string _article;
        private readonly string _indefiniteArticle;

    }
}
