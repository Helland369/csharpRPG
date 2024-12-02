using RaceClass;

namespace PlayerClass
{


    class Player
    {
        private int _exp, _level, _hp, _maxHp, _dexterity, _strength, _intelligence, _constitution, _wisdom, _charisma;
        private string _name, _race, _sex;

        private Race selectedRace;

        public Player()
        {
            this._exp = 0;
            this._level = 1;
            this._hp = 100;
            this._maxHp = 100;
            this._dexterity = 10;
            this._strength = 10;
            this._intelligence = 10;
            this._constitution = 10;
            this._wisdom = 10;
            this._charisma = 10;
            this._name = "";
            this._race = ";";
            this._sex = "";
        }

        private List<Race> raceList = new List<Race>() {
            new Race(75, 12,10,15,8,8,8,"Gnome"),
            new Race(85, 12,10,15,8,8,8,"Dwarf"),
            new Race(85, 12,10,15,8,8,8,"Goblin"),
            new Race(100, 12,10,15,8,8,8,"Human"),
            new Race(95, 12,10,15,8,8,8,"Elf"),
            new Race(130, 12,10,15,8,8,8,"Tauren"),
            new Race(125, 12,10,15,8,8,8,"Orc")
        };

        public int _Exp
        {
            get { return this._exp; }

            set { this._exp = value; }
        }

        public int _Hp
        {
            get { return this._hp; }

            set { this._hp = value; }
        }

        public int _Levei
        {
            get { return this._level; }

            set { this._level = value; }
        }

        public string _Name
        {
            get { return this._name; }

            set { this._name = value; }
        }

        public int characterHeal()
        {
            if (this._hp < this._maxHp)
                this._hp = this._hp + 10;
            return this._hp;
        }

        public void characterCreat()
        {

            Console.WriteLine("***Character Cration***");
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
                this._dexterity = selectedRace._Dexterity;
                this._strength = selectedRace._Strength;
                this._intelligence = selectedRace._Intelligence;
                this._constitution = selectedRace._Constitution;
                this._wisdom = selectedRace._Wisdom;
                this._charisma = selectedRace._Charisma;
                this._race = selectedRace._Race;
            }

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
            }
            else if (selectSex == "Female")
            {
                this._sex = selectSex;
            }

            Console.WriteLine("Select a name for you character");

            string nameIn = Console.ReadLine();
            if (!string.IsNullOrEmpty(nameIn))
            {
                nameIn = char.ToUpper(nameIn[0]) + nameIn.Substring(1);
            }

            this._name = nameIn;

            Console.WriteLine($"{this._hp}");
            Console.WriteLine($"{this._dexterity}");
            Console.WriteLine($"{this._strength}");
            Console.WriteLine($"{this._intelligence}");
            Console.WriteLine($"{this._constitution}");
            Console.WriteLine($"{this._wisdom}");
            Console.WriteLine($"{this._charisma}");
            Console.WriteLine($"{this._race}");
            Console.WriteLine($"{this._sex}");
            Console.WriteLine($"{this._name}");
        }
    }
}
