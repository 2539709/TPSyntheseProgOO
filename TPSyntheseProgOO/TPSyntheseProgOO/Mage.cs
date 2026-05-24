namespace TPSyntheseProgOO
{
    /// <summary>
    /// Héros de type mage, peut utiliser des gemmes et dispose d'une attaque magique
    /// </summary>
    class Mage : Hero
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="level">Le niveau du mage</param>
        public Mage(int level) : 
            base("Doric, le mage", StartingLifePoints, StartingStrengthPoints, level, StartingProtectionPoints)
        {
            _magicPoints = StartingMagicPoints;
        }

        /// <summary>
        /// Retourne les dommages infligés : attaque de base ou attaque magique si assez de points de magie
        /// </summary>
        protected override int AttackDamage()
        {
           
            if (MagicPoints >= MagicAttack)
            {
                Console.WriteLine("1) Attaque de base ");
                Console.WriteLine("2) Attaque magique ");

                string? choix;

                while (true)
                {
                    Console.Write("Choix: ");
                    choix = Console.ReadLine();

                    if (choix == "1" || choix == "2")
                    {
                        break;
                    }
                    Console.WriteLine("Choix invalide");
                }
                if (choix == "2")
                {
                    _magicPoints -= MagicAttack;
                    return MagicAttack * Level;
                }
                
            }
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
        /// Retourne les points de magie du mage
        /// </summary>
        public override int MagicPoints { get { return _magicPoints; } }

        /// <summary>
        /// Le mage peut utiliser des gemmes
        /// </summary>
        public override bool CanUseGem { get { return true; } }

        /// <summary>
        /// Ajoute des points de magie au mage
        /// </summary>
        /// <param name="points">Le nombre de points à ajouter</param>
        public override void AddMagicPoints(int points)
        {
            _magicPoints += points;
        }

        //Les constantes
        private const int StartingLifePoints = 40;
        private const int StartingStrengthPoints = 5;
        private const int StartingProtectionPoints = 0;
        private const int StartingMagicPoints = 50;
        private const int MagicAttack = 20;

        // Les attributs
        private int _magicPoints;
    }
}
