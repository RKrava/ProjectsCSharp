using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaBuffCSharp
{
    class Program
    {
        public string[] nick_radiant = new string[5];
        public string[] nick_dire = new string[5];

        class Player
        {
            public string name;
            public int[] number_games; 
        }

        class Team {
            public void Get_Radiant()
            {
                foreach (string i in nick_dire)
                {
                    Console.WriteLine(i);
                }
            }
            public void Get_Dire()
            {
                foreach (string i in nick_radiant)
                {
                    Console.WriteLine(i);
                }
            }
        }
        class Game
        {
            public int number;
            
        }
        static void Main(string[] args)
        {

        }
    }
}
