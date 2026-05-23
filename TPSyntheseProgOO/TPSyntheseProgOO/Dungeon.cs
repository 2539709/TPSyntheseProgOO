namespace TPSyntheseProgOO
{
    class Dungeon
    {   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="hero"></param>
        public Dungeon(string folderPath, Hero hero)
        {
            _hero = hero;
            for (int i = 0; i < PieceNumber; i++)
            {
                _rooms[i] = new Room(folderPath + i + ".txt");
            }
            
        }

        
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
            if (_hero.HasWon)
            {
                Console.WriteLine("Félicitations, vous avez gagné !");
            }
            else
            {
                Console.WriteLine("Partie terminée, vous êtes mort au combat");
            }

            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();
        }

        private const int PieceNumber = 10;
        private Stack<int> _history = new();
        private Room[] _rooms = new Room[PieceNumber];
        private Hero _hero;
    }
}
