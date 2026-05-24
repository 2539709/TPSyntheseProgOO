namespace TPSyntheseProgOO
{
    /// <summary>
    /// Classe abstraite représentant un héros jouable
    /// </summary>
    abstract class Hero : Character
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name">Le nom du héros</param>
        /// <param name="lifePoints">Les points de vie de départ</param>
        /// <param name="strengthPoints">Les points de force de départ</param>
        /// <param name="level">Le niveau du héros</param>
        /// <param name="protectionPoints">Les points de protection de départ</param>
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
        /// Ajoute des points de protection au héros
        /// </summary>
        /// <param name="points">Le nombre de points à ajouter</param>
        public void AddProtection(int points)
        {
            _protectionPoints += points;
        }

        /// <summary>
        /// Équipe une arme et met à jour la force du héros
        /// </summary>
        /// <param name="weapon">L'arme à équiper</param>
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

        /// <summary>
        /// Ajoute des points de magie (utilisé par le mage)
        /// </summary>
        /// <param name="points">Le nombre de points à ajouter</param>
        public virtual void AddMagicPoints(int points) { }

        /// <summary>
        /// Indique si le héros peut utiliser une arme
        /// </summary>
        public virtual bool CanUseWeapon { get { return false; } }

        /// <summary>
        /// Indique si le héros peut utiliser une gemme
        /// </summary>
        public virtual bool CanUseGem { get { return false; } }

        /// <summary>
        /// Retourne les points de magie du héros
        /// </summary>
        public virtual int MagicPoints { get { return 0; } }

        public Inventory Inventory { get; }

        /// <summary>
        /// Indique si le héros a gagné la partie
        /// </summary>
        public bool HasWon { get { return _hasWon; } }

        /// <summary>
        /// Indique que le héros a gagné la partie
        /// </summary>
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
