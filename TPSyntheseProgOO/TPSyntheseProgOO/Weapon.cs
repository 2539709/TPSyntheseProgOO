namespace TPSyntheseProgOO
{
    class Weapon : Item
    {
        public Weapon(string name, string article, int strengthPoints) :
            base(name, article)
        {
            _strengthPoints = strengthPoints;
        }

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

        public override bool IsConsumable { get { return false; } }

        public int StrengthPoints { get { return _strengthPoints; } }

        private readonly int _strengthPoints;
    }
}
