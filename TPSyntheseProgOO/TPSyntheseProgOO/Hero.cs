namespace TPSyntheseProgOO
{
    abstract class Hero : Character
    {
        protected Hero(string name, int lifePoints, int strengthPoints, int level, int protectionPoints) : 
            base(name, lifePoints, strengthPoints)
        {
            Level = level;
            ProtectionPoints = protectionPoints;
            Inventory = new();
        }

        public int Level { get; }

        public int ProtectionPoints { get; private set; }

        public Inventory Inventory { get; }

        
        
    }
}
