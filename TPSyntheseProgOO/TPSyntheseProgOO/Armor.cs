namespace TPSyntheseProgOO
{
    class Armor : Item
    {
        public Armor(string name, string article, int protectionPoints) :
            base(name, article)
        {
            _protectionPoints = protectionPoints;
        }

        public int ProtectionPoints { get { return _protectionPoints; } }

        private readonly int _protectionPoints;
    }
}
