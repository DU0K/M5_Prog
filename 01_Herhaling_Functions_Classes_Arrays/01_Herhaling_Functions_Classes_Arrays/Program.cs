using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace _01_Herhaling_Functions_Classes_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                          Name, Score, Health
            Player player1 = new Player("John", 100, 100);
            Debug.WriteLine(player1.Stats());
        }
    }

    internal class Player
    {
        string _playerName;
        int _score;
        bool _isAlive;
        int _healtPoints;
        public player(string playerName, int score, int healtPoints)
        {
            string _playerName = playerName;
            int _score = score;
            bool _isAlive = true;
            int _healtPoints = healtPoints;
        }
        public void TakeDamage(int damage)
        {
            _healtPoints -= damage;
            if (_healtPoints <= 0)
            {
                _isAlive = false;
            }
        }
        public string Stats()
        {
            return _playerName + " has a score of " + _score + " and is " + (_isAlive ? "alive " : "dead ") + "and has " + _healtPoints + "HP";
        }
    }
}