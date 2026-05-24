namespace TPSyntheseProgOO
{
    /// <summary>
    /// Ennemi de type assassin, avec une chance d'infliger un coup critique et d'esquiver les attaques
    /// </summary>
    class Assassin : Enemy
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public Assassin() :
            base ("assassin", "l'", StartingLifePoints, StartingStrengthPoints)
        {
            
        }

        /// <summary>
        /// Retourne les dommages infligés : 30% de chance d'infliger un coup critique
        /// </summary>
        protected override int AttackDamage()
        {
            int chance = _random.Next(100);
            if (chance < 30)
            {
                return StrengthPoints + StrengthPoints / 5;
            }
            else
            {
                return StrengthPoints;
            }
        }

        /// <summary>
        /// Retourne les dommages reçus : 30% de chance d'esquiver complètement l'attaque
        /// </summary>
        /// <param name="damage">Les dommages bruts reçus</param>
        protected override int DamageReceived(int damage)
        {
            int esquive = _random.Next(100);
            if (esquive < 30)
            {
                damage = 0;
            }
            return damage;
        }

        
        // Les attributs
        private const int StartingLifePoints = 40;
        private const int StartingStrengthPoints = 20;
        private readonly Random _random = new Random();
    }
}
