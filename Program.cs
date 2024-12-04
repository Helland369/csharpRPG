using ChacterClass;
using EnemyClass;


class Program {

    static void Main(string[] args) {


        Character character = new Character();
        Enemy enemy = new Enemy();

        character.characterCreat();

        Console.Clear();

        enemy.randomEnemy();
        enemy.randomEnemyName();
        
        while (character.isAlive() && enemy.isAlive()) {

            Console.WriteLine($"Player HP: {character._Hp}\tEnemy HP: {enemy._Hp}");

            Console.WriteLine("[1] Attack\n" +
                              "[2] Heal");

            int x = Convert.ToInt32(Console.ReadLine());

            switch(x) {
                case 1:
                    character.basicAttack(enemy);
                    if (enemy.isAlive()) {
                        enemy.basicEnemyAttack(character);
                    }
                    break;
                case 2:
                    character.characterHeal();
                    break;
                default:
                    break;
            }
            
        }
        
    }
}
