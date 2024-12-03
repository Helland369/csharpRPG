using RaceClass;
using PlayerClass;

namespace EnemyClass
{


    class Enemy
    {

        private int _exp, _level, _hp, _maxHp, _dexterity, _strength, _intelligence, _constitution, _wisdom, _charisma;
        private string _name, _race, _sex;

        private Race selectedRace;

        private string[] enemyNames = { "Per", "Pål", "Espen", "Gunnar", "Terje", "Hans", "Kake", "Kjøttkake", "Karbonade", "Pizza" };

        private List<Race> raceList = new List<Race>() {
            new Race(75, 12,10,15,8,8,8,"Gnome"),
            new Race(85, 12,10,15,8,8,8,"Dwarf"),
            new Race(85, 12,10,15,8,8,8,"Goblin"),
            new Race(100, 12,10,15,8,8,8,"Human"),
            new Race(95, 12,10,15,8,8,8,"Elf"),
            new Race(130, 12,10,15,8,8,8,"Tauren"),
            new Race(125, 12,10,15,8,8,8,"Orc"),
            new Race(125, 12,10,15,8,8,8,"Troll"),
            new Race(125, 12,10,15,8,8,8,"Ogre"),
            new Race(125, 12,10,15,8,8,8,"Centaur")
        };

        public Enemy() {
            this._exp = 0;
            this._level = 1;
            this._hp = 100;
            this._maxHp = 100;
            this._dexterity = 0;
            this._strength = 0;
            this._intelligence = 0;
            this._constitution = 0;
            this._wisdom = 0;
            this._charisma = 0;
            this._name = "";
            this._race = "";
            this._sex = "";
        }
        
        public int _Exp {
            get { return _exp; }
            set { _exp = value; }
        }

        public int _Level {
            get { return _level; }
            set { _level = value; }
        }

        public int _Hp {
            get { return _hp; }
            set { _hp = value; }
        }

        public int _MaxHp {
            get { return _maxHp; }
            set { _maxHp = value; }
        }

        public int _Dexterity {
            get { return _dexterity; }
            set { _dexterity = value; }
        }

        public int _Strength {
            get { return _strength; }
            set { _strength = value; }
        }

        public int _Intelligence {
            get { return _intelligence; }
            set { _intelligence = value; }
        }

        public int _Constitution {
            get { return _constitution; }
            set { _constitution = value; }
        }

        public int _Wisdom {
            get { return _wisdom; }
            set { _wisdom = value; }
        }

        public int _Charisma {
            get { return _charisma; }
            set { _charisma = value; }
        }

        public string _Name {
            get { return _name; }
            set { _name = value; }
        }

        public string _Race {
            get { return _race; }
            set { _race = value; }
        }

        public string _Sex {
            get { return _sex; }
            set { _sex = value; }
        }

        public void randomEnemy() {
            Random rand = new Random();

            int randI = rand.Next(0, raceList.Count());

            selectedRace = raceList[randI];

            this._hp = selectedRace._Hp;
            this._dexterity = selectedRace._Dexterity;
            this._strength = selectedRace._Strength;
            this._intelligence = selectedRace._Intelligence;
            this._constitution = selectedRace._Constitution;
            this._wisdom = selectedRace._Wisdom;
            this._charisma = selectedRace._Charisma;
            this._race = selectedRace._Race;
        }

        public string randomEnemyName() {
            Random rand = new Random();

            int i = rand.Next(0, enemyNames.Length);
            this._name = this.enemyNames[i];

            return this._name;
        }

        public int basicEnemyAttack(Player target) {
            if (this._hp > 0) {
                target._Hp = target._Hp -= this._strength;
            }

            return this._hp;
        }
    }
}
