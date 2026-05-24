namespace TPSyntheseProgOO
{
    /// <summary>
    /// Héros de type guerrier, peut utiliser des armes et réduit les dommages reçus avec sa protection
    /// </summary>
    class Warrior : Hero
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="level">Le niveau du guerrier</param>
        public Warrior(int level) : base("Throd, le guerrier", StartingLifePoints, StartingStrengthPoints, level, StartingProtectionPoints)
        {
            
        }

        /// <summary>
        /// Retourne les dommages infligés : force multipliée par le niveau
        /// </summary>
        protected override int AttackDamage()
        {
            return StrengthPoints * Level;
        }

        /// <summary>
        /// Retourne les dommages reçus après soustraction des points de protection
        /// </summary>
        /// <param name="damage">Les dommages bruts reçus</param>
        protected override int DamageReceived(int damage)
        {
            return damage - ProtectionPoints;
        }

        /// <summary>
        /// Le guerrier peut utiliser des armes
        /// </summary>
        public override bool CanUseWeapon { get { return true; } }

        // Les attributs
        private const int StartingLifePoints = 80;
        private const int StartingStrengthPoints = 10;
        private const int StartingProtectionPoints = 0;
        
    }
}
