namespace TPSyntheseProgOO
{
    abstract class Item : IComparable<Item>, IEquatable<Item>
    {
        protected Item(string name, string article)
        {
            _name = name;
            _article = article;
        }

        // Les propriétées
        public string Name { get { return _name; } }
        public string Article { get { return _article; } }

        public bool Equals(Item? other)
        {
            if (other == null)
            {
                return false;
            }

            return GetType() == other.GetType() && Name == other.Name;
        }
        public int CompareTo(Item? other)
        {
            if (other == null)
            {
                return 1;
            }
            return Name.CompareTo(other.Name);
        }

       

        // Les attributs
        private readonly string _name;
        private readonly string _article;
        
    }
}
