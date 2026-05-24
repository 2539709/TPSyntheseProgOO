namespace TPSyntheseProgOO
{
    class Potion : Item
    {
        public Potion(string name, string article, int lifePoints) :
            base(name, article)
        {
            _lifePoints = lifePoints;
        }
        public override void ApplyEffect(Hero hero)
        {
            hero.AddLifePoints(_lifePoints);
            Console.WriteLine($"Vous buvez {Article}{Name}, votre vie est maintenant de {hero.LifePoints}");
        }

        public int LifePoints { get { return _lifePoints; } }

        private readonly int _lifePoints;
    }
}
