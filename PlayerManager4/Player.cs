using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace Players
{
    public class Player : IComparable<Player>
    {
        public string Name { get;  }
        public int Score { get;  }
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
        public override string ToString()
        {
            return $"{Name} - Score: {Score}";
        }
        public int CompareTo(Player other)
        {
            if (other == null) return 1;
            return other.Score.CompareTo(this.Score);
            
        }
        
    }
    
}
