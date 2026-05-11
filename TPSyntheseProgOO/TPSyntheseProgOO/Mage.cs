namespace TPSyntheseProgOO
{
    class Mage : Hero
    {
        public Mage(int level) : 
            base("Doric", StartingLifePoints, StartingStrengthPoints, level, StartingProtectionPoints)
        {
            MagicPoints = StartingMagicPoints;
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
                    MagicPoints -= MagicAttack;
                    return MagicAttack * Level;
                }
                
            }
            return StrengthPoints * Level;
            
        }

        protected override int DamageReceived(int damage)
        {
            return damage - ProtectionPoints;
        }

        public int MagicPoints { get; private set; }

        private const int Zero = 0;
        private const int StartingLifePoints = 40;
        private const int StartingStrengthPoints = 5;
        private const int StartingProtectionPoints = Zero;
        private const int StartingMagicPoints = 50;
        private const int MagicAttack = 20;
    }
}
