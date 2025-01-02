namespace RaceClass
{

    class Race
    {
        private int _hp, _evasion, _attackPower, _mana, _defencePower;
        private string _race;

        public Race(int hp, int evasion, int attackPower, int mana, int defencePower, string race)
        {
            _hp = hp;
            _evasion = evasion;
            _attackPower = attackPower;
            _mana = mana;
            _defencePower = defencePower;
            _race = race;
        }

        // get set
        
        public int _Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public int _Evasion
        {
            get { return _evasion; }
            set { _evasion = value; }
        }

        public int _AttackPower
        {
            get { return _attackPower; }
            set { _attackPower = value; }
        }

        public int _Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }

        public int _DefencePower
        {
            get { return _defencePower; }
            set { _defencePower = value; }
        }

        public string _Race
        {
            get { return _race; }
            set { _race = value; }
        }
    }
}
