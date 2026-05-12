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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Item? other)
        {
            if (other == null)
            {
                return false;
            }

            return GetType() == other.GetType() && Name == other.Name;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Item? other)
        {
            if (other == null)
            {
                return 1;
            }
            return Name.CompareTo(other.Name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hero"></param>
        public abstract void ApplyEffect(Hero hero);

        /// <summary>
        /// Permet de savoir si un item peut être réutilisé
        /// </summary>
        public virtual bool IsConsumable { get { return true; } }

        /// <summary>
        /// 
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
