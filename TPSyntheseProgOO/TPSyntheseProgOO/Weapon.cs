namespace TPSyntheseProgOO
{
    /// <summary>
    /// Item de type arme, augmente la force du héros lorsqu'elle est équipée
    /// </summary>
    class Weapon : Item
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name">Le nom de l'arme</param>
        /// <param name="article">L'article associé au nom</param>
        /// <param name="strengthPoints">Les points de force accordés</param>
        public Weapon(string name, string article, int strengthPoints) :
            base(name, article)
        {
            _strengthPoints = strengthPoints;
        }

        /// <summary>
        /// Équipe l'arme sur le héros si celui-ci peut l'utiliser
        /// </summary>
        /// <param name="hero">Le héros qui utilise l'arme</param>
        public override void ApplyEffect(Hero hero)
        {
            if (!hero.CanUseWeapon)
            {
                Console.WriteLine("Vous ne pouvez pas utiliser d'arme");
                return;
            }
            hero.EquipWeapon(this);
            Console.WriteLine($"Vous utilisez {Article}{Name}, votre force est maintenant de {hero.StrengthPoints}");
        }

        /// <summary>
        /// Une arme n'est pas consommable
        /// </summary>
        public override bool IsConsumable { get { return false; } }

        /// <summary>
        /// Retourne les points de force accordés par l'arme
        /// </summary>
        public int StrengthPoints { get { return _strengthPoints; } }

        // Attribut
        private readonly int _strengthPoints;
    }
}
