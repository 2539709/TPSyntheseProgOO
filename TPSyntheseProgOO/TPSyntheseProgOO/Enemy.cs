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
        /// <param name="lifePoints">Les points de vie de départ</param>
        /// <param name="strengthPoints">Les points de force de départ</param>
        protected Enemy(string name, string article, int lifePoints, int strengthPoints) : 
            base(name, lifePoints, strengthPoints)
        {
            _article = article;
        }

        public string Article { get { return _article; } }

        /// <summary>
        /// Retourne l'article contracté avec "de" pour le message de défaite
        /// </summary>
        public string DefeatArticle { get { return _article == "le " ? "du " : "de " + _article; } }

        // Attribut
        private readonly string _article;

    }
}
