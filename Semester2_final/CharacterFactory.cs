using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4
{
    [Serializable]
    public class CharacterFactory
    {
        private Random _rand = new Random();
        private ItemFactory _itemFactory = new ItemFactory();

        public CharacterFactory()
        { }

        private string[] _playerNames = new string[]
            {
                "QuickBlade",
                "RedShadow",
                "TripleHands",
                "SwiftSword",
                "HiddenReaper"
            };

        private string[] _enemyNames = new string[]
            {
                "Goblin",
                "BlueOgre",
                "RatKnight",
                "Overlord",
                "Unlucky Turtle"
            };

        private string RandomizePlayerName(string[] _playerNames)
        {
            return _playerNames[_rand.Next(0, _playerNames.Length)];
        }

        private string RandomizeEnemyName(string[] _enemyNames)
        {
            return _enemyNames[_rand.Next(0, _enemyNames.Length)];
        }

        public Character SpawnPlayer()
        {
            string playerNames = RandomizePlayerName(_playerNames);

            int health = _rand.Next(90, 100);
            int attack = _rand.Next(60, 100);
            int defense = _rand.Next(60, 100);

            Character player = new Character(playerNames, health, attack, defense);

            player.Helmet = _itemFactory.SpawnHelmet();
            player.Vest = _itemFactory.SpawnVest();
            player.Weapon = _itemFactory.SpawnWeapon();
            player.Potion = _itemFactory.SpawnPotion();

            return player;
        }

        public Character SpawnEnemy(int level)
        {
            string enemyNames = RandomizeEnemyName(_enemyNames);
            Character enemy;

            if(level == 5 || level == 10 || level == 15)
            {
                int health = _rand.Next(80, 120);
                int attack = _rand.Next(60, 80);
                int defense = _rand.Next(1000, 15000);
                enemy = new Character(enemyNames, health, attack, defense);
            }
            else
            {
                int health = _rand.Next(50, 75);
                int attack = _rand.Next(25, 50);
                int defense = _rand.Next(25, 50);
                enemy = new Character(enemyNames, health, attack, defense);
                
            }
            
            enemy.Helmet = _itemFactory.SpawnHelmet();
            enemy.Vest = _itemFactory.SpawnVest();
            enemy.Weapon = _itemFactory.SpawnWeapon();
            enemy.Potion = _itemFactory.SpawnPotion();
            enemy.Bag.Add(_itemFactory.SpawnHelmet());
            enemy.Bag.Add(_itemFactory.SpawnVest());
            enemy.Bag.Add(_itemFactory.SpawnWeapon());
            return enemy;
        }
    }
}
