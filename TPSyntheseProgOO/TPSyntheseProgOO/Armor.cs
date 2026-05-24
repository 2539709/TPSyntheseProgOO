namespace TPSyntheseProgOO
{
    class Armor : Item
    {
        public Armor(string name, string article, int protectionPoints) :
            base(name, article)
        {
            _protectionPoints = protectionPoints;
        }

        public override void ApplyEffect(Hero hero)
        {
            hero.AddProtection(ProtectionPoints);
            Console.WriteLine($"Vous portez {Article}{Name}, votre protection est maintenant de {hero.ProtectionPoints} ");
        }

        public int ProtectionPoints { get { return _protectionPoints; } }

        private readonly int _protectionPoints;
    }
}
