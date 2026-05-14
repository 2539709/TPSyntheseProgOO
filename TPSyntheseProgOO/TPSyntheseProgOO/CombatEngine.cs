namespace TPSyntheseProgOO
{
    class CombatEngine
    {

        public static void Fight( Hero hero, Enemy enemy)
        {
            string title = $"=   Combat entre {hero.Name} et {enemy.Name}   =";
            string ligne = new string('=', title.Length);
            Console.WriteLine(ligne);
            Console.WriteLine(title);
            Console.WriteLine(ligne);

            while (hero.LifePoints > 0 && enemy.LifePoints > 0)
            {
                hero.Attack(enemy);

                if (enemy.LifePoints > 0)
                {
                    enemy.Attack(hero);
                }
            }
        }

        private static void PrintHeroStats(Hero hero)
        {
            int barreLength = hero.LifePoints * 10 / hero.MaxLifePoints;
            string barre = new string('=', barreLength) + new string(' ', 10 - barreLength);
            Console.WriteLine($"{hero.Name}");
            Console.WriteLine($"Vie:  {hero.LifePoints}/{hero.MaxLifePoints} [{barre}]");
            Console.WriteLine($"Force: {hero.StrengthPoints}");
            Console.WriteLine($"Niveau: {hero.Level}");
            Console.WriteLine($"Protection: {hero.ProtectionPoints}");
        }

        private static void PrintEnemyStats(Enemy enemy)
        {
            int barreLength = enemy.LifePoints * 10 / enemy.MaxLifePoints;
            string barre = new string('=', barreLength) + new string(' ', 10 - barreLength);
            Console.WriteLine($"{enemy.Name}");
            Console.WriteLine($"Vie:  {enemy.LifePoints}/{enemy.MaxLifePoints} [{barre}]");
            Console.WriteLine($"Force: {enemy.StrengthPoints}");
        }


    }
}
