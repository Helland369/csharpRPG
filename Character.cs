using RaceClass;
using EnemyClass;

namespace ChacterClass
{


    class Character
    {
        private int _level, _hp, _maxHp, _mana, _maxMana, _evasion, _attackPower, _defencePower;
        long _exp;
        private string _name, _race, _sex;

        private Race _selectedRace;

        public Character()
        {
            _exp = 0;
            _level = 1;
            _hp = 100;
            _maxHp = 100;
            _evasion = 10;
            _attackPower = 10; 
            _mana = 10;
            _maxMana = 30;
            _defencePower = 10;
            _name = "";
            _race = ";";
            _sex = "";
            _selectedRace = SelectRace();
        }

        private List<Race> _races = new List<Race>() {
            new Race(75, 20,30,30,16, "Gnome"),
            new Race(85, 20,30,30,16,"Dwarf"),
            new Race(85, 20,30,30,16,"Goblin"),
            new Race(100, 16,30,30,20,"Human"),
            new Race(95, 22,30,30,20,"Elf"),
            new Race(130, 13,30,30,30,"Tauren"),
            new Race(125, 16,30,30,26,"Orc")
        };

        // get set

        public int _Level { get { return _level; } set { _level = value; } }
        public int _Hp { get { return _hp; } set { _hp = value; } }
        public int _MaxHp { get { return _maxHp; } set { _maxHp = value; } }
        public int _Evasion { get { return _evasion; } set { _evasion = value; } }
        public int _AttackPower { get { return _attackPower; } set { _attackPower = value; } }
        public int _Mana { get { return _mana; } set { _mana = value; } }
        public int _DefencePower { get { return _defencePower; } set { _defencePower = value; } }
        public long _Exp { get { return this._exp; } set { this._exp = value; } }
        public string _Name { get { return this._name; } set { this._name = value; } }

        // functions aka methods

        public int CharacterHeal()
        {
            if (_hp < _maxHp)
                _hp = _hp + 10;
            return _hp;
        }

        public int RestoreMana()
        {
            if (_mana < _maxMana)
                _mana = _mana + 10;
            return _mana;
        }

        public int BasicAttack(Enemy target)
        {
            target._Hp = target._Hp - _attackPower;
            _mana = _mana - 5;

            return _hp;
        }

        public bool IsAlive()
        {
            return _hp > 0;
        }

        Race SelectRace()
        {
            Console.WriteLine("Select a race:");

            for (int i = 0; i < _races.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. Race: {_races[i]._Race}");
            }

            Console.WriteLine("Write the race you want!");
            int input = Convert.ToInt32(Console.ReadLine());

            _selectedRace = _races[input - 1];

            if (input == 1 || input == 2 || input == 3 || input == 4 || input == 5 || input == 6 || input == 7)
            {

                _hp = _selectedRace._Hp;
                _evasion = _selectedRace._Evasion;
                _attackPower = _selectedRace._AttackPower;
                _mana = _selectedRace._Mana;
                _defencePower = _selectedRace._DefencePower;
                _race = _selectedRace._Race;
            }

            return _selectedRace;
        }

        string SelectSex()
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
                _sex = selectSex;
                return _sex;
            }
            else if (selectSex == "Female")
            {
                _sex = selectSex;
                return _sex;
            }
            return _sex;
        }

        string SelectName()
        {

            Console.WriteLine("Select a name for you character");

            string nameIn = Console.ReadLine();
            if (!string.IsNullOrEmpty(nameIn))
            {
                nameIn = char.ToUpper(nameIn[0]) + nameIn.Substring(1);
            }
            _name = nameIn;

            return _name;
        }

        public void CharacterCreat()
        {

            Console.WriteLine("***Character Cration***");

            SelectRace();
            SelectSex();
            SelectName();

            Console.WriteLine($"{_hp}");
            Console.WriteLine($"{_evasion}");
            Console.WriteLine($"{_attackPower}");
            Console.WriteLine($"{_mana}");
            Console.WriteLine($"{_defencePower}");
            Console.WriteLine($"{_race}");
            Console.WriteLine($"{_sex}");
            Console.WriteLine($"{_name}");
        }
    }
}
