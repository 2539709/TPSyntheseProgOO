namespace TPSyntheseProgOO
{
    /// <summary>
    /// Item de type gemme, ajoute des points de magie au héros si celui-ci peut les utiliser
    /// </summary>
    class Gem : Item
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name">Le nom de la gemme</param>
        /// <param name="article">L'article associé au nom</param>
        /// <param name="magicPoints">Les points de magie accordés</param>
        public Gem(string name, string article, int magicPoints) : 
            base(name, article)
        {
            _magicPoints = magicPoints;
        }

        /// <summary>
        /// Ajoute les points de magie de la gemme au héros si celui-ci peut les utiliser
        /// </summary>
        /// <param name="hero">Le héros qui utilise la gemme</param>
        public override void ApplyEffect(Hero hero)
        {
            if (!hero.CanUseGem)
            {
                Console.WriteLine("Vous n'avez aucun pouvoir magique, la pierre n'a pas d'effet");
                return;
            }
            hero.AddMagicPoints(MagicPoints);
            Console.WriteLine($"Vous utilisez: {Article}{Name}, vos points de magie sont maintenant de {hero.MagicPoints}");
        }

        /// <summary>
        /// Retourne les points de magie accordés par la gemme
        /// </summary>
        public int MagicPoints { get { return _magicPoints; } }

        //Attributs
        private readonly int _magicPoints;
    }
}
