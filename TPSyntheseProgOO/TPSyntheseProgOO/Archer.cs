namespace TPSyntheseProgOO
{
    /// <summary>
    /// Héros de type archère, dont les dommages d'attaque sont aléatoires
    /// </summary>
    class Archer : Hero
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="level">Le niveau de l'archère</param>
        public Archer(int level) : base("Elwena, l'archère", StartingLifePoints, StartingStrengthPoints, level, StartingProtectionPoints)
        {
            
        }

        /// <summary>
        /// Retourne les dommages infligés : valeur aléatoire entre la moitié et le double de la force
        /// </summary>
        protected override int AttackDamage()
        {
            int attaque = _random.Next(StrengthPoints / 2, StrengthPoints + StrengthPoints / 2 + 1 );
            return attaque;
        }

        /// <summary>
        /// Retourne les dommages reçus après soustraction des points de protection
        /// </summary>
        /// <param name="damage">Les dommages bruts reçus</param>
        protected override int DamageReceived(int damage)
        {
            return damage - ProtectionPoints;
        }

        // Les attributs
        private const int StartingLifePoints = 50;
        private const int StartingStrengthPoints = 10;
        private const int StartingProtectionPoints = 0;
        private Random _random = new();
    }

}
