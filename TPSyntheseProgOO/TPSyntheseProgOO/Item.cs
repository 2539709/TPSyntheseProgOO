namespace TPSyntheseProgOO
{
    /// <summary>
    /// Classe abstraite représentant un objet ramassable dans le donjon
    /// </summary>
    abstract class Item : IComparable<Item>, IEquatable<Item>
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name">Le nom de l'objet</param>
        /// <param name="article">L'article associé au nom (ex: "le ", "l'")</param>
        protected Item(string name, string article)
        {
            _name = name;
            _article = article;
        }

        // Les propriétés
        public string Name { get { return _name; } }
        public string Article { get { return _article; } }

        /// <summary>
        /// Vérifie si deux items sont identiques (même type et même nom)
        /// </summary>
        /// <param name="other">L'item à comparer</param>
        /// <returns>True si les items sont identiques, false sinon</returns>
        public bool Equals(Item? other)
        {
            if (other == null)
            {
                return false;
            }

            return GetType() == other.GetType() && Name == other.Name;
        }

        /// <summary>
        /// Compare deux items par ordre alphabétique selon leur nom
        /// </summary>
        /// <param name="other">L'item à comparer</param>
        /// <returns>Un entier négatif, zéro ou positif selon l'ordre</returns>
        public int CompareTo(Item? other)
        {
            if (other == null)
            {
                return 1;
            }
            return Name.CompareTo(other.Name);
        }

        /// <summary>
        /// Applique l'effet de l'objet sur le héros
        /// </summary>
        /// <param name="hero">Le héros sur lequel appliquer l'effet</param>
        public abstract void ApplyEffect(Hero hero);

        /// <summary>
        /// Permet de savoir si un item peut être réutilisé
        /// </summary>
        public virtual bool IsConsumable { get { return true; } }

        /// <summary>
        /// Affiche l'objet dans la pièce
        /// </summary>
        public void Print()
        {
            Console.WriteLine(" - " + _article + _name);
        }
       

        // Les attributs
        private readonly string _name;
        private readonly string _article;
        
    }
}
