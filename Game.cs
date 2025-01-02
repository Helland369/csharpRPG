using ChacterClass;
using EnemyClass;

namespace GameClass
{


    class Game
    {
        private Character _character = new Character();
        private Enemy _enemy = new Enemy();

        private void Combat()
        {
            _enemy.RandomEnemy();
            _enemy.RandomEnemyName();

            while (_character.IsAlive() && _enemy.isAlive())
            {

                Console.WriteLine($"Player Stats:\tEnemy stats:\n" +
                                  $"Hp: {_character._Hp}|\t|Hp: {_enemy._Hp}\n" +
                                  $"Mana: {_character._Mana}|\t|Mana: {_enemy._Hp}\n" +
                                  $"Atk: {_character._AttackPower}|\t|Atk: {_enemy._AttackPower}\n" +
                                  $"Def: {_character._DefencePower}|\t|Def {_enemy._DefencePower}\n");

                Console.WriteLine("[1] Attack\n" +
                                  "[2] Heal");

                int x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        _character.BasicAttack(_enemy);
                        if (_enemy.isAlive())
                        {
                            _enemy.BasicEnemyAttack(_character);
                        }
                        break;
                    case 2:
                        _character.CharacterHeal();
                        break;
                    case 3:
                        _character.RestoreMana();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }

        public void MainGame()
        {
            _character.CharacterCreat();

            Console.Clear();

            Combat();
        }
    }
}
