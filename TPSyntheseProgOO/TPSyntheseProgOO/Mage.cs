namespace TPSyntheseProgOO
{
    class Mage : Hero
    {   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="level"></param>
        public Mage(int level) : 
            base("Doric", StartingLifePoints, StartingStrengthPoints, level, StartingProtectionPoints)
        {
            _magicPoints = StartingMagicPoints;
        }

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

        protected override int DamageReceived(int damage)
        {
            return damage - ProtectionPoints;
        }

        /// <summary>
        /// 
        /// </summary>
        public int MagicPoints { get { return _magicPoints; } }

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
