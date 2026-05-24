namespace TPSyntheseProgOO
{
    /// <summary>
    /// Classe abstraite représentant un personnage du jeu
    /// </summary>
    abstract class Character
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name">Le nom du personnage</param>
        /// <param name="lifePoints">Les points de vie de départ</param>
        /// <param name="strengthPoints">Les points de force de départ</param>
        protected Character(string name, int lifePoints, int strengthPoints)
        {
            Name = name;
            _lifePoints = lifePoints;
            MaxLifePoints = lifePoints;
            _strengthPoints = strengthPoints;
        }

        // Les propriétés
        public string Name { get; }
        public int LifePoints { get { return _lifePoints; } }
        public int StrengthPoints { get { return _strengthPoints; } }
        public int MaxLifePoints { get; }

        /// <summary>
        /// Ajoute des points de vie sans dépasser le maximum
        /// </summary>
        /// <param name="points">Le nombre de points à ajouter</param>
        public void AddLifePoints(int points)
        {
            _lifePoints += points;
            if (_lifePoints > MaxLifePoints)
            {
                _lifePoints = MaxLifePoints;
            }
        }

        /// <summary>
        /// Ajoute des points de force
        /// </summary>
        /// <param name="points">Le nombre de points à ajouter</param>
        public void AddStrengthPoints(int points)
        {
            _strengthPoints += points;
        }

        /// <summary>
        /// Méthode qui enlève les points de vie lors d'un combat
        /// </summary>
        /// <param name="damage">Le nombre de points retiré</param>
        public void TakeDamage(int damage)
        {
            _lifePoints -= damage;
            if (_lifePoints < 0)
            {
                _lifePoints = 0;
            }
        }

        /// <summary>
        /// Permet à un character d'attaquer
        /// </summary>
        /// <param name="target">La cible qui se fait attaquer</param>
        public void Attack(Character target)
        {
            int damage = target.DamageReceived(AttackDamage());
            target.TakeDamage(damage);
        }

        /// <summary>
        /// Retourne les dommages infligés lors d'une attaque
        /// </summary>
        protected abstract int AttackDamage();

        /// <summary>
        /// Retourne les dommages reçus après réduction
        /// </summary>
        /// <param name="damage">Les dommages bruts reçus</param>
        protected abstract int DamageReceived(int damage);


        // Les attributs
        private int _lifePoints;
        private int _strengthPoints;

    }
}
