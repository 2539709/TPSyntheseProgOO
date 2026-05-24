namespace TPSyntheseProgOO
{
    /// <summary>
    /// Item de type potion, restaure des points de vie au héros
    /// </summary>
    class Potion : Item
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name">Le nom de la potion</param>
        /// <param name="article">L'article associé au nom</param>
        /// <param name="lifePoints">Les points de vie restaurés</param>
        public Potion(string name, string article, int lifePoints) :
            base(name, article)
        {
            _lifePoints = lifePoints;
        }

        /// <summary>
        /// Ajoute les points de vie de la potion au héros
        /// </summary>
        /// <param name="hero">Le héros qui boit la potion</param>
        public override void ApplyEffect(Hero hero)
        {
            hero.AddLifePoints(_lifePoints);
            Console.WriteLine($"Vous buvez {Article}{Name}, votre niveau de vie est maintenant de {hero.LifePoints}");
        }

        /// <summary>
        /// Retourne les points de vie restaurés par la potion
        /// </summary>
        public int LifePoints { get { return _lifePoints; } }

        // Attribut
        private readonly int _lifePoints;
    }
}
