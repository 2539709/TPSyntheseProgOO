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

        /// <summary>
        /// 
        /// </summary>
        public void AddProtection(int points)
        {
            _protectionPoints += points;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="weapon"></param>
        public void EquipWeapon(Weapon weapon)
        {
            if (_equippedWeapon != null)
            {   
                // Enlever l'arme courante
                AddStrengthPoints(-_equippedWeapon.StrengthPoints);
            }
            AddStrengthPoints(weapon.StrengthPoints);
            _equippedWeapon = weapon;
        }

        public virtual void AddMagicPoints(int points) { }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool CanUseWeapon { get { return false; } }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool CanUseGem { get { return false; } }

        /// <summary>
        /// 
        /// </summary>
        public Inventory Inventory { get; }

        /// <summary>
        /// 
        /// </summary>
        public bool HasWon { get { return _hasWon; } }

        public void Win()
        {
            _hasWon = true;
        }

        // Les attributs
        private int _protectionPoints;
        private Weapon? _equippedWeapon;
        private bool _hasWon;
        
        
    }
}
