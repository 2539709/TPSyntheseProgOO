using TPSyntheseProgOO;

try
{
    string title = "~          Le donjon de Zangdarax          ~";
    string ligne = new('~', title.Length);
    Console.WriteLine(ligne);
    Console.WriteLine(title);
    Console.WriteLine(ligne);

    Console.WriteLine("\nChoix du personnage:");
    Console.WriteLine(" G) Throd, le guerrier");
    Console.WriteLine(" M) Doric, le mage");
    Console.WriteLine(" A) Elwena, l'archère");
    Console.Write("\n> ");
    string? temp = Console.ReadLine();
    string choixHero = temp == null ? "" : temp.ToUpper();

    // Validation du choix
    if (choixHero != "G" && choixHero != "M" && choixHero != "A")
    {
        Console.WriteLine("Choix invalide");
        Console.WriteLine("Appuyer sur une touche pour continuer...");
        Console.ReadKey();
        return;
    }


    // Gestion du niveau    
    const int MinLevel = 1;
    const int MaxLevel = 4;
    Console.Write($"\nIndiquez le niveau (entre {MinLevel} et {MaxLevel}): ");
    string tempLevel = Console.ReadLine();
    int level;
    try
    {
        level = int.Parse(tempLevel == null ? "0" : tempLevel);
        if (level < MinLevel || level > MaxLevel)
        {
            throw new Exception();
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Choix invalide");
        Console.WriteLine("Appuyer sur une touche pour continuer...");
        Console.ReadKey();
        return;
    }

    // Création du héros
    Hero hero = new Warrior(level);
    string heroClass = "le guerrier";
    switch (choixHero)
    {
        case "M":
            hero = new Mage(level);
            heroClass = "le mage";
            break;
        case "A":
            hero = new Archer(level);
            heroClass = "l'archère";
            break;
    }

    Console.WriteLine($"\n{hero.Name}, {heroClass} de niveau {level}");
    Console.WriteLine("\nAppuyer sur une touche pour continuer...");
    Console.ReadKey();
    

    // Lancement du jeu
    const string FolderPath = "../../../pieces/";
    Dungeon dungeon = new Dungeon(FolderPath, hero);
    dungeon.Play();

}
catch (Exception)
{
    Console.WriteLine("Bug inattendu");
}
