namespace TPSyntheseProgOO
{
    /// <summary>
    /// Classe qui gère le déroulement des combats entre un héros et un ennemi
    /// </summary>
    class CombatEngine
    {
        /// <summary>
        /// Lance et gère le combat tour par tour entre un héros et un ennemi
        /// </summary>
        /// <param name="hero">Le héros qui combat</param>
        /// <param name="enemy">L'ennemi à combattre</param>
        public static void Fight(Hero hero, Enemy enemy)
        {
            string title = $"=   Combat entre {hero.Name} et {enemy.IndefiniteArticle}{enemy.Name}   =";
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

                int damage = hero.Attack(enemy);
                Console.WriteLine($"Attaque de {hero}");
                if (damage == 0)
                {
                    Console.WriteLine("  Attaque esquivée, aucun dommage infligé");
                }                   
                else
                {
                    Console.WriteLine($"  Dommage: {damage}");
                }
                   
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

                int damageHero = enemy.Attack(hero);
                Console.WriteLine($"Attaque de {enemy}");
                Console.WriteLine($"  Dommage: {damageHero}");                    
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
                Console.WriteLine($"Défaite de {hero}");
            }
                
        }

        //Affiche les statistiques du héros et de l'ennemi
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
