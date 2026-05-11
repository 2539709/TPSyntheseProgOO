namespace TPSyntheseProgOO
{
    class Room
    {   
        /// <summary>
        /// Constructeur qui les différentes pièces
        /// </summary>
        /// <param name="filePath">Le chemin du fichier</param>
        public Room(string filePath)
        {
            using (StreamReader input = new StreamReader(filePath))
            {
                _name = input.ReadLine();
                _description = input.ReadLine();
                string[] doors = input.ReadLine().Split(Separator);

                // Attribuer les portes
                _leftRoom = doors[0] == "" ? -1 : int.Parse(doors[0]);
                _forwardRoom = doors[1] == "" ? -1 : int.Parse(doors[1]);
                _rightRoom = doors[2] == "" ? -1 : int.Parse(doors[2]);

                string enemyLine = input.ReadLine();

            }
        }

        public void Visit(Hero hero)
        {
            
        }

        // Les attributs
        private readonly string _name;
        private readonly string _description;
        private readonly int _leftRoom;
        private readonly int _forwardRoom;
        private readonly int _rightRoom;
        private Enemy? _enemy;
        private readonly List<Item> _items;
        private const string Separator = ":";

    }
}
