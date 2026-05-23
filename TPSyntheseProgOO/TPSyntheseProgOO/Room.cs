using System.Security.AccessControl;

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
                    case "O":
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
                    itemLine = input.ReadLine();
                }

            }
        }

        /// <summary>
        /// Affiche les informations des pièces lors de la navigation
        /// </summary>
        /// <param name="hero">Le héro sélectionné pour la partie</param>
        public int Visit(Hero hero, bool canGoBack)
        {
            Console.Clear();
            string line = new string('~', _name.Length + 6);
            Console.WriteLine(line);
            Console.WriteLine("~  " + _name + "  ~");
            Console.WriteLine(line);
            Console.WriteLine(_description);


            if (_items.Count > 0)
            {   
                // Afficher les items dans une pièce
                Console.WriteLine("La pièce contient " + _items.Count + " objet" + 
                    (_items.Count > 1 ? "s" : "" ) + ":");

                foreach (var item in _items)
                {
                    item.Print();
                }
            }

            #region Doors

            string doors = "";

            if (_leftRoom != - 1)
            {
                doors = AddVirgule(doors) + "une porte à gauche";
            }

            if (_forwardRoom != -1)
            {
                doors = AddVirgule(doors) + "une porte en avant";
            }

            if (_rightRoom != -1)
            {
                doors = AddVirgule(doors) + "une porte à droite";
            }

            if (doors != "")
            {
                Console.WriteLine("Il y a " + doors);
            }
            #endregion


            #region Mini-Menu
            Console.WriteLine("I) Voir l'inventaire");

            if (_items.Count > 0)
            {
                Console.WriteLine("O) Ramasser les objets");
            }

            if (_leftRoom != -1)
            {
                Console.WriteLine("G) Aller à gauche");
            }

            if (_forwardRoom != - 1)
            {
                Console.WriteLine("A) Aller en avant");
            }

            if (_rightRoom != - 1)
            {
                Console.WriteLine("D) Aller à droite");
            }

            if (canGoBack)
            {
                Console.WriteLine("R) Retourner à la pièce précédente ");
            }
            #endregion

            while (true)
            {
                string choix;

                Console.Write("> ");
                string? temp = Console.ReadLine();
                choix = temp == null ? "" : temp.ToUpper();

                switch (choix)
                {
                    case "I":
                        hero.Inventory.Print();
                        break;
                    case "O":
                        foreach (var item in _items)
                        {
                            hero.Inventory.Add(item);
                        }
                        _items.Clear();
                        break;
                    case "G":
                        return _leftRoom;
                    case "A":
                        return _forwardRoom;
                    case "D":
                        return _rightRoom;
                    case "R":
                        return -1;
                    default:
                        break;
                }
            }

        }

        // Méthode qui permet d'ajouter une virgule ou pas à la fin d'un text
        private string AddVirgule(string text)
        {
            if (text != "")
            {
                return text += ", ";
            }
            return text;
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
