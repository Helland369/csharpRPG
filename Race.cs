namespace RaceClass
{

    class Race
    {
        private int _hp, _evasion, _attackPower, _mana, _defencePower;
        private string _race;

        public Race(int hp, int evasion, int attackPower, int mana, int defencePower, string race)
        {
            this._hp = hp;
            this._evasion = evasion;
            this._attackPower = attackPower;
            this._mana = mana;
            this._defencePower = defencePower;
            this._race = race;
        }

        // get set
        
        public int _Hp
        {
            get { return this._hp; }
            set { this._hp = value; }
        }

        public int _Evasion
        {
            get { return _evasion; }
            set { this._evasion = value; }
        }

        public int _AttackPower
        {
            get { return this._attackPower; }
            set { this._attackPower = value; }
        }

        public int _Mana
        {
            get { return this._mana; }
            set { this._mana = value; }
        }

        public int _DefencePower
        {
            get { return this._defencePower; }
            set { this._defencePower = value; }
        }

        public string _Race
        {
            get { return this._race; }
            set { this._race = value; }
        }
    }
}
