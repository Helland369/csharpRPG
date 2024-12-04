using RaceClass;
using ChacterClass;

namespace EnemyClass
{


    //private int _level, _hp, _maxHp, _evasion, _attackPower, _mana, _defencePower;
    class Enemy
    {

        private int _level, _hp, _maxHp, _evasion, _attackPower, _mana, _defencePower;
        long _exp;
        private string _name, _race, _sex;

        private Race selectedRace;

        private string[] enemyNames = { "Per", "Pål", "Espen", "Gunnar", "Terje", "Hans", "Kake", "Kjøttkake", "Karbonade", "Pizza" };

        private List<Race> raceList = new List<Race>() {
            new Race(75, 12,10,15,8,"Gnome"),
            new Race(85, 12,10,15,8,"Dwarf"),
            new Race(85, 12,10,15,8,"Goblin"),
            new Race(100, 12,10,15,8,"Human"),
            new Race(95, 12,10,15,8,"Elf"),
            new Race(130, 12,10,15,8,"Tauren"),
            new Race(125, 12,10,15,8,"Orc"),
            new Race(125, 12,10,15,8,"Troll"),
            new Race(125, 12,10,15,8,"Ogre"),
            new Race(125, 12,10,15,8,"Centaur")
        };

        public Enemy()
        {
            this._exp = 0;
            this._level = 1;
            this._hp = 100;
            this._maxHp = 100;
            this._evasion = 0;
            this._attackPower = 0;
            this._mana = 0;
            this._defencePower = 0;
            this._name = "";
            this._race = "";
            this._sex = "";
        }

        // get set

        public long _Exp
        {
            get { return _exp; }
            set { _exp = value; }
        }

        public int _Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public int _Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public int _MaxHp
        {
            get { return _maxHp; }
            set { _maxHp = value; }
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

        public string _Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string _Race
        {
            get { return _race; }
            set { _race = value; }
        }

        public string _Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        // functions aka methods
        
        public bool isAlive()
        {
            return this._hp > 0;
        }

        public void randomEnemy()
        {
            Random rand = new Random();

            int randI = rand.Next(0, raceList.Count());

            selectedRace = raceList[randI];

            this._hp = selectedRace._Hp;
            this._evasion = selectedRace._Evasion;
            this._attackPower = selectedRace._AttackPower;
            this._mana = selectedRace._Mana;
            this._defencePower = selectedRace._DefencePower;
            this._race = selectedRace._Race;
        }

        public string randomEnemyName()
        {
            Random rand = new Random();

            int i = rand.Next(0, enemyNames.Length);
            this._name = this.enemyNames[i];

            return this._name;
        }

        public int basicEnemyAttack(Character target)
        {
            target._Hp = target._Hp - this._attackPower;

            return this._hp;
        }
    }
}
