namespace TPSyntheseProgOO
{
    /// <summary>
    /// Ennemi de type orque, dont les dommages diminuent avec sa vie
    /// </summary>
    class Orc : Enemy
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public Orc() : 
            base("orque", "l'", StartingLifePoints, StartingStrengthPoints)
        {
            
        }

        /// <summary>
        /// Retourne les dommages infligés : proportionnels à la vie restante
        /// </summary>
        protected override int AttackDamage()
        {
            int attackDamage =  StrengthPoints * LifePoints / MaxLifePoints;
            return attackDamage;
        }

        /// <summary>
        /// Retourne les dommages reçus sans réduction
        /// </summary>
        /// <param name="damage">Les dommages bruts reçus</param>
        protected override int DamageReceived(int damage)
        {
            return damage;
        }

        // Les attributs
        private const int StartingLifePoints = 50;
        private const int StartingStrengthPoints = 10;

    }
}
