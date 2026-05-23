namespace TPSyntheseProgOO
{
    class CombatEngine
    {

        public static void Fight(Hero hero, Enemy enemy)
        {
            string title = $"=   Combat entre {hero.Name} et {enemy.Name}   =";
            string ligne = new string('=', title.Length);

            while (hero.LifePoints > 0 && enemy.LifePoints > 0)
            {
                // Attaque du héros
                Console.Clear();
                Console.WriteLine(ligne);
                Console.WriteLine(title);
                Console.WriteLine(ligne);
                Console.WriteLine();
                PrintStats(hero, enemy);
                Console.WriteLine();

                int enemyLifePointsBefore = enemy.LifePoints;
                hero.Attack(enemy);
                int damage = enemyLifePointsBefore - enemy.LifePoints;
                Console.WriteLine($"Attaque de {hero.Name}");
                Console.WriteLine($"  Dommage: {damage}");

                if (enemy.LifePoints <= 0)
                {
                    break;
                }

                Console.WriteLine("\nAppuyer sur une touche pour continuer...");
                Console.ReadKey();

                // Attaque de l'ennemi
                Console.Clear();
                Console.WriteLine(ligne);
                Console.WriteLine(title);
                Console.WriteLine(ligne);
                Console.WriteLine();
                PrintStats(hero, enemy);
                Console.WriteLine();

                int heroLifePointsBefore = hero.LifePoints;
                enemy.Attack(hero);
                int damageHero = heroLifePointsBefore - hero.LifePoints;
                Console.WriteLine($"Attaque de {enemy.Name}");
                if (damageHero == 0)
                {
                    Console.WriteLine("  Attaque esquivée, aucun dommage infligé");
                }
                else
                {
                    Console.WriteLine($"  Dommage: {damageHero}");
                }                    
                if (hero.LifePoints > 0)
                {
                    Console.WriteLine("\nAppuyer sur une touche pour continuer...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine();
            if (hero.LifePoints > 0)
            {
                Console.WriteLine($"Défaite {enemy.DefeatArticle}{enemy.Name}");
            }

            else
            {
                Console.WriteLine($"Défaite de {hero.Name}");
            }
                
        }

        private static void PrintStats(Hero hero, Enemy enemy)
        {
            int herroBarre = hero.LifePoints * 10 / hero.MaxLifePoints;
            string heroBarreProgression = new string('=', herroBarre) + new string(' ', 10 - herroBarre);
            int enemyBarre = enemy.LifePoints * 10 / enemy.MaxLifePoints;
            string enemyBarreProgression = new string('=', enemyBarre) + new string(' ', 10 - enemyBarre);

            Console.WriteLine(($"\t{hero.Name}").PadRight(45) + $"\t{enemy.Name}");
            Console.WriteLine(($"\tVie:  {hero.LifePoints}/{hero.MaxLifePoints} " +
                $"[{heroBarreProgression}]").PadRight(45) +
                $"\tVie:  {enemy.LifePoints}/{enemy.MaxLifePoints} [{enemyBarreProgression}]");
            Console.WriteLine(($"\tForce: {hero.StrengthPoints}").PadRight(45) +
                $"\tForce: {enemy.StrengthPoints}");
            Console.WriteLine($"\tNiveau: {hero.Level}");
            Console.WriteLine($"\tProtection: {hero.ProtectionPoints}");
        }


    }
}
