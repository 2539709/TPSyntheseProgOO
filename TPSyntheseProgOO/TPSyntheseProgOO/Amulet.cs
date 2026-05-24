namespace TPSyntheseProgOO
{
    class Amulet : Item
    {
        public Amulet(string name, string article) : base (name, article)
        {
            
        }

        public override void ApplyEffect(Hero hero)
        {
            hero.Win();
            Console.WriteLine($"Félicitations, vous avez trouvé {Article}{Name}!");
        }
    }
}
