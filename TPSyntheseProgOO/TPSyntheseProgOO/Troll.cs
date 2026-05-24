namespace TPSyntheseProgOO
{
    /// <summary>
    /// Ennemi de type troll, résistant aux petites attaques
    /// </summary>
    class Troll : Enemy
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public Troll() : base ("troll", "le ", StartingLifePoints, StartingStrengthPoints )
        {
            
        }

        /// <summary>
        /// Retourne les dommages infligés : égaux à la force
        /// </summary>
        protected override int AttackDamage()
        {
            return StrengthPoints;
        }

        /// <summary>
        /// Retourne les dommages reçus : annulés si inférieurs à 15
        /// </summary>
        /// <param name="damage">Les dommages bruts reçus</param>
        protected override int DamageReceived(int damage)
        {
            if (damage < 15)
            {
                damage = 0;
            }
            return damage;
        }
        
        // Les attributs
        private const int StartingLifePoints = 80;
        private const int StartingStrengthPoints = 10;
    }
}
