namespace TPSyntheseProgOO
{
    abstract class Character
    {
        protected Character(string name, int lifePoints, int strengthPoints)
        {
            Name = name;
            _lifePoints = lifePoints;
            MaxLifePoints = lifePoints;
            _strengthPoints = strengthPoints;
        }

        public string Name { get; }
        public int LifePoints { get { return _lifePoints; } }
        public int StrengthPoints { get { return _strengthPoints; } }
        public int MaxLifePoints { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="points"></param>
        public void AddLifePoints(int points)
        {
            _lifePoints += points;
            if (_lifePoints > MaxLifePoints)
            {
                _lifePoints = MaxLifePoints;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="points"></param>
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

        protected abstract int AttackDamage();

        protected abstract int DamageReceived(int damage);


        // Les attributs
        private int _lifePoints;
        private int _strengthPoints;

    }
}
