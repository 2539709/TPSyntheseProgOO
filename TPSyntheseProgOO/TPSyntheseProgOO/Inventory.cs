namespace TPSyntheseProgOO
{
    class Inventory
    {
        public Inventory()
        {
            
        }

        /// <summary>
        /// Ajoute un item dans la liste
        /// </summary>
        /// <param name="item"></param>
        public void Add(Item item)
        {
            int index = _items.IndexOf(item);

            if (index == -1)
            {
                _items.Add(item);
                _quantities.Add(1);
            }
            else
            {
                _quantities[index]++;
            }
        }

        /// <summary>
        /// Affiche les items
        /// </summary>
        public void Print()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("Inventaire vide");
                return;
            }

            for (int i = 0; i < _items.Count; i++)
            {
                string quantite = _quantities[i] > 1 ? "[ " + _quantities[i] + "]" : "";
                Console.WriteLine(" " + (i + 1) + " )" + _items[i].Article + _items[i].Name + quantite);
            }
            Console.WriteLine(" 0) Retour");

        }

        public void UseItem(Item item, Hero hero)
        {   
            int index = _items.IndexOf(item);

            item.ApplyEffect(hero);

            if (item.IsConsumable)
            {
                // Enlève la quantité si un item ne doit pas être réutilisé
                _quantities[index]--;
                if (_quantities[index] == 0)
                {
                    _items.RemoveAt(index);
                    _quantities.RemoveAt(index);
                }
            }       
    
        }

        // Les attributs
        private readonly List<Item> _items = new();
        private readonly List<int> _quantities = new();
    }
}
