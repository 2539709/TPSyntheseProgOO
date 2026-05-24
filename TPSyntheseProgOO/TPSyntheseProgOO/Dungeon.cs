namespace TPSyntheseProgOO
{
    /// <summary>
    /// Représente le donjon, gère la navigation entre les pièces et la progression de la partie
    /// </summary>
    class Dungeon
    {
        /// <summary>
        /// Constructeur qui charge toutes les pièces du donjon
        /// </summary>
        /// <param name="folderPath">Le chemin du dossier contenant les fichiers de pièces</param>
        /// <param name="hero">Le héros sélectionné pour la partie</param>
        public Dungeon(string folderPath, Hero hero)
        {
            _hero = hero;
            for (int i = 0; i < PieceNumber; i++)
            {
                _rooms[i] = new Room(folderPath + i + ".txt");
            }
            
        }

        /// <summary>
        /// Lance la boucle principale du jeu jusqu'à la victoire ou la mort du héros
        /// </summary>
        public void Play()
        {
            int currentRoom = 0;

            while (_hero.LifePoints > 0 && !_hero.HasWon)
            {
                bool canGoBack = _history.Count > 0;
                int nextRoom = _rooms[currentRoom].Visit(_hero, canGoBack);

                if (nextRoom == -1 )
                {
                    currentRoom = _history.Pop();
                }
                else
                {
                    _history.Push(currentRoom);
                    currentRoom = nextRoom;
                }

            }
            if (!_hero.HasWon)
            {
                Console.WriteLine("\nPartie terminée, vous êtes mort au combat");
            }
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();
        }

        // Les attributs
        private const int PieceNumber = 10;
        private Stack<int> _history = new();
        private Room[] _rooms = new Room[PieceNumber];
        private Hero _hero;
    }
}
