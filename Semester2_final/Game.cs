using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace PT4
{
    [Serializable]
    public class Game
    {
        protected int _level = 1;
        protected int _gold;
        protected Character _player;
        protected Character _enemy;
        private CharacterFactory _characterFactory = new CharacterFactory();
        private ItemFactory _itemFactory = new ItemFactory();

        public Game()
        {
            _player = _characterFactory.SpawnPlayer();
            _enemy = _characterFactory.SpawnEnemy(_level);
            
        }

        public static Game LoadGame(string path)
        {
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                var f = new BinaryFormatter();
                Game _game = (Game)f.Deserialize(stream);
                return _game;
            }
        }

        public static void SaveGame(string path, Game g)
        {
            using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                var f = new BinaryFormatter();
                f.Serialize(stream, g);
                stream.Flush();
            }
            
        }
        
        public int Level
        {
            get { return _level; }
        }

        public void NextLevel()
        {
            ++_level;
            _enemy = _characterFactory.SpawnEnemy(_level);
            
        }

        public int Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }

        public Character Player
        {
            get { return _player; }
            //set { _player = value; }
        }

        public Character Enemy
        {
            get { return _enemy; }
            //set { _enemy = value; }
        }

    }
}
