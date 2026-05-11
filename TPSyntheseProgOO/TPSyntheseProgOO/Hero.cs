namespace TPSyntheseProgOO
{
    abstract class Hero : Character
    {
        protected Hero(string name, int lifePoints, int strengthPoints, int level, int protectionPoints) : 
            base(name, lifePoints, strengthPoints)
        {
            Level = level;
            _protectionPoints = protectionPoints;
            Inventory = new();
        }

        public int Level { get; }

        public int ProtectionPoints { get { return _protectionPoints; } }

        public Inventory Inventory { get; }
        private int _protectionPoints;

        
        
    }
}
