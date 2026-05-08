namespace TPSyntheseProgOO
{
    abstract class Item : IComparable<Item>, IEquatable<Item>
    {
        public int CompareTo(Item? other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Item? other)
        {
            throw new NotImplementedException();
        }
    }
}
