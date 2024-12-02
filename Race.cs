namespace RaceClass
{


    class Race
    {
        private int _hp, _dexterity, _strength, _intelligence, _constitution, _wisdom, _charisma;
        private string _race;

        public Race(int hp, int dex, int str, int intt, int cons, int wis, int cha, string race)
        {
            this._hp = hp;
            this._dexterity = dex;
            this._strength = str;
            this._intelligence = intt;
            this._constitution = cons;
            this._wisdom = wis;
            this._charisma = cha;
            this._race = race;
        }

        public int _Hp
        {
            get { return this._hp; }
            set { this._hp = value; }
        }

        public int _Dexterity
        {
            get { return _dexterity; }
            set { this._dexterity = value; }
        }

        public int _Strength
        {
            get { return this._strength; }
            set { this._strength = value; }
        }

        public int _Intelligence
        {
            get { return this._intelligence; }
            set { this._intelligence = value; }
        }

        public int _Constitution
        {
            get { return this._constitution; }
            set { this._constitution = value; }
        }

        public int _Wisdom
        {
            get { return this._wisdom; }
            set { this._wisdom = value; }
        }

        public int _Charisma
        {
            get { return this._charisma; }
            set { this._charisma = value; }
        }

        public string _Race
        {
            get { return this._race; }
            set { this._race = value; }
        }
    }
}
