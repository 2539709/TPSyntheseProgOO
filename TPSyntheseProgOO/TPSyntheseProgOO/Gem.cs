namespace TPSyntheseProgOO
{
    class Gem : Item
    {
        public Gem(string name, string article, int magicPoints) : 
            base(name, article)
        {
            _magicPoints = magicPoints;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hero"></param>
        public override void ApplyEffect(Hero hero)
        {
            if (!hero.CanUseGem)
            {
                Console.WriteLine("Vous n'avez aucun pouvoir magique, la pierre n'a pas d'effet");
                return;
            }
            hero.AddMagicPoints(MagicPoints);
        }

        public int MagicPoints { get { return _magicPoints; } }

        private readonly int _magicPoints;
    }
}
