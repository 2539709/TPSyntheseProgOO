namespace TPSyntheseProgOO
{
    class Room
    {   
        /// <summary>
        /// Constructeur qui lit les fichiers
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

                switch (enemyLine)
                {
                    case "0":
                        _enemy = new Orc();
                        break;
                    case "T":
                        _enemy = new Troll();
                        break;
                    case "A":
                        _enemy = new Assassin();
                        break;
                    default:
                        break;
                }

                string itemLine = input.ReadLine();
                while (itemLine != null && itemLine != "")
                {
                    string[] values = itemLine.Split(ItemSeparator);
                    switch (values[0])
                    {
                        case "arme":
                            _items.Add(new Weapon(values[1], values[2], int.Parse(values[3])));
                            break;
                        case "armure":
                            _items.Add(new Armor(values[1], values[2], int.Parse(values[3])));
                            break;
                        case "potion":
                            _items.Add(new Potion(values[1], values[2], int.Parse(values[3])));
                            break;
                        case "pierre":
                            _items.Add(new Gem(values[1], values[2], int.Parse(values[3])));
                            break;
                        case "amulette":
                            _items.Add(new Amulet(values[1], values[2]));
                            break;
                        default:
                            break;
                    }
                }

            }
        }

        public void Visit(Hero hero)
        {
            string line = new string('~', _name.Length + 6);
            Console.WriteLine(line);
            Console.WriteLine("~  " + _name + "   ~");
            Console.WriteLine(line);
            Console.WriteLine(_description);

            if (_items.Count > 0)
            {
                Console.WriteLine("La pièce contient " + _items.Count + " objet" + 
                    (_items.Count > 1 ? "s" : "" ) + ":");

                foreach (var item in _items)
                {
                    item.Print();
                }
            }

           
        }

        // Les attributs
        private readonly string _name;
        private readonly string _description;
        private readonly int _leftRoom;
        private readonly int _forwardRoom;
        private readonly int _rightRoom;
        private Enemy? _enemy;
        private readonly List<Item> _items = new();
        private const string Separator = ":";
        private const string ItemSeparator = ";";

    }
}
