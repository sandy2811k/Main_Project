using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.IEnumerable_IEnumerator
{
    public class Player //Class
    {
        private int runs;
        private string name;

        public Player(int runs, string name)//constructor
        {
            this.name = name;
            this.runs = runs;
        }
        public override string ToString()
        {
            return $"{runs}->{name}";
        }
    }
    public class Team : IEnumerable  // class 2
    {
        private Player[] players;
        public Team()
        {
            players = new Player[3]
             {
                 new Player(5000,"Sachin T"),
                 new Player(4000,"Virat K"),
                 new Player(3000,"Rohit S")
            };
    }
        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }

        public class Program //main Class
        {
            static void Main(string[] args)
            {
                Team team = new Team();
                foreach (Player item in team) //For print all data
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
