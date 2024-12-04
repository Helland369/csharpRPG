using ChacterClass;
using EnemyClass;

namespace GameClass
{


    class Game
    {
        private Character character = new Character();
        private Enemy enemy = new Enemy();

        private void combat()
        {
            enemy.randomEnemy();
            enemy.randomEnemyName();

            while (character.isAlive() && enemy.isAlive())
            {

                Console.WriteLine($"Player Stats:\tEnemy stats:\n" +
                                  $"Hp: {character._Hp}|\t|Hp: {enemy._Hp}\n" +
                                  $"Mana: {character._Mana}|\t|Mana: {enemy._Hp}\n" +
                                  $"Atk: {character._AttackPower}|\t|Atk: {enemy._AttackPower}\n" +
                                  $"Def: {character._DefencePower}|\t|Def {enemy._DefencePower}\n");

                Console.WriteLine("[1] Attack\n" +
                                  "[2] Heal");

                int x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        character.basicAttack(enemy);
                        if (enemy.isAlive())
                        {
                            enemy.basicEnemyAttack(character);
                        }
                        break;
                    case 2:
                        character.characterHeal();
                        break;
                    case 3:
                        character.restoreMana();
                        break;
                    default:
                        break;
                }
            }
        }

        public void mainGame()
        {
            character.characterCreat();

            Console.Clear();

            combat();
        }
    }
}
