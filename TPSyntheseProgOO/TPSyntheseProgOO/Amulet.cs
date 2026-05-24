namespace TPSyntheseProgOO
{
    /// <summary>
    /// Item de type amulette, fait gagner la partie au héros qui la trouve
    /// </summary>
    class Amulet : Item
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name">Le nom de l'amulette</param>
        /// <param name="article">L'article associé au nom</param>
        public Amulet(string name, string article) : base (name, article)
        {
            
        }

        /// <summary>
        /// Déclenche la victoire du héros
        /// </summary>
        /// <param name="hero">Le héros qui trouve l'amulette</param>
        public override void ApplyEffect(Hero hero)
        {
            hero.Win();
            Console.WriteLine($"Félicitations, vous avez trouvé {Article}{Name}!");
        }
    }
}
