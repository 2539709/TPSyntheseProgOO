namespace TPSyntheseProgOO
{
    /// <summary>
    /// Item de type armure, ajoute des points de protection au héros
    /// </summary>
    class Armor : Item
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name">Le nom de l'armure</param>
        /// <param name="article">L'article associé au nom</param>
        /// <param name="protectionPoints">Les points de protection accordés</param>
        public Armor(string name, string article, int protectionPoints) :
            base(name, article)
        {
            _protectionPoints = protectionPoints;
        }

        /// <summary>
        /// Ajoute les points de protection de l'armure au héros
        /// </summary>
        /// <param name="hero">Le héros qui porte l'armure</param>
        public override void ApplyEffect(Hero hero)
        {
            hero.AddProtection(ProtectionPoints);
            Console.WriteLine($"Vous portez {Article}{Name}, votre protection est maintenant de {hero.ProtectionPoints} ");
        }

        /// <summary>
        /// Retourne les points de protection accordés par l'armure
        /// </summary>
        public int ProtectionPoints { get { return _protectionPoints; } }

        // Attribut
        private readonly int _protectionPoints;
    }
}
