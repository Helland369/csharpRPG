using RaceClass;
using EnemyClass;

namespace ChacterClass
{


    class Character
    {
        private int _level, _hp, _maxHp, _mana, _maxMana, _evasion, _attackPower, _defencePower;
        long _exp;
        private string _name, _race, _sex;

        private Race selectedRace;

        public Character()
        {
            this._exp = 0;
            this._level = 1;
            this._hp = 100;
            this._maxHp = 100;
            this._evasion = 10;
            this._attackPower = 10;
            this._mana = 10;
            this._maxMana = 30;
            this._defencePower = 10;
            this._name = "";
            this._race = ";";
            this._sex = "";
            this.selectedRace = selectRace();
        }

        private List<Race> raceList = new List<Race>() {
            new Race(75, 20,30,30,16, "Gnome"),
            new Race(85, 20,30,30,16,"Dwarf"),
            new Race(85, 20,30,30,16,"Goblin"),
            new Race(100, 16,30,30,20,"Human"),
            new Race(95, 22,30,30,20,"Elf"),
            new Race(130, 13,30,30,30,"Tauren"),
            new Race(125, 16,30,30,26,"Orc")
        };

        // get set

        public int _Level
        {
            get { return this._level; }

            set { this._level = value; }
        }

        public int _Hp
        {
            get { return this._hp; }
            set { this._hp = value; }

        }

        public int _MaxHp
        {
            get { return this._maxHp; }
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

        public long _Exp
        {
            get { return this._exp; }
            set { this._exp = value; }
        }

        public string _Name
        {
            get { return this._name; }

            set { this._name = value; }
        }

        // functions aka methods

        public int characterHeal()
        {
            if (this._hp < this._maxHp)
                this._hp = this._hp + 10;
            return this._hp;
        }

        public int restoreMana()
        {
            if (this._mana < this._maxMana)
                this._mana = this._mana + 10;
            return this._mana;
        }

        public int basicAttack(Enemy target)
        {
            target._Hp = target._Hp - this._attackPower;
            this._mana = this._mana - 5;

            return this._hp;
        }

        public bool isAlive()
        {
            return this._hp > 0;
        }

        Race selectRace()
        {
            Console.WriteLine("Select a race:");

            for (int i = 0; i < raceList.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. Race: {raceList[i]._Race}");
            }

            Console.WriteLine("Write the race you want!");
            int input = Convert.ToInt32(Console.ReadLine());

            selectedRace = raceList[input - 1];

            if (input == 1 || input == 2 || input == 3 || input == 4 || input == 5 || input == 6 || input == 7)
            {

                this._hp = selectedRace._Hp;
                this._evasion = selectedRace._Evasion;
                this._attackPower = selectedRace._AttackPower;
                this._mana = selectedRace._Mana;
                this._defencePower = selectedRace._DefencePower;
                this._race = selectedRace._Race;
            }

            return selectedRace;
        }

        string selectSex()
        {

            Console.WriteLine("Select a sex for you character");
            Console.WriteLine("Male\nFemale");

            string selectSex = Console.ReadLine();

            if (!string.IsNullOrEmpty(selectSex))
            {
                selectSex = char.ToUpper(selectSex[0]) + selectSex.Substring(1);
            }

            if (selectSex == "Male")
            {
                this._sex = selectSex;
                return this._sex;
            }
            else if (selectSex == "Female")
            {
                this._sex = selectSex;
                return this._sex;
            }
            return this._sex;
        }

        string selectName()
        {

            Console.WriteLine("Select a name for you character");

            string nameIn = Console.ReadLine();
            if (!string.IsNullOrEmpty(nameIn))
            {
                nameIn = char.ToUpper(nameIn[0]) + nameIn.Substring(1);
            }
            this._name = nameIn;

            return this._name;
        }

        public void characterCreat()
        {

            Console.WriteLine("***Character Cration***");

            selectRace();
            selectSex();
            selectName();

            Console.WriteLine($"{this._hp}");
            Console.WriteLine($"{this._evasion}");
            Console.WriteLine($"{this._attackPower}");
            Console.WriteLine($"{this._mana}");
            Console.WriteLine($"{this._defencePower}");
            Console.WriteLine($"{this._race}");
            Console.WriteLine($"{this._sex}");
            Console.WriteLine($"{this._name}");
        }
    }
}
