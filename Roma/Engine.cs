using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roma
{
    
    public class Engine
    {
        public List<int> tableDices = new List<int>();//тут будут все кубики на столе
        Random rnd = new Random();
        List<Player> players = new List<Player>();
        public void InitPlayers(int PlayersCount)
        {
            if(PlayersCount < 2 || PlayersCount >4) { throw new Exception("Недопустимое кол-во игроков"); }
            for (int i = 0; i < PlayersCount; i++)
            {
                players.Add(new Player());
            }
        }


        public void ThrowDices()
        {
           
           foreach (Player p in players)
           {
                for (int i = 0; i < 5; i++)
                {
                    int DiceToAdd = rnd.Next(1,7);
                    Console.Write(DiceToAdd + " ");
                    p.dices.Add(DiceToAdd);
                    tableDices.Add(DiceToAdd);

                }
                Console.WriteLine("\n");
                
            }
            Console.WriteLine("кубики на столе:");
            foreach (int item in tableDices)//выаодит все кубики на столе
            {
                Console.Write(item + " ");
            }


        }

        public void CheckDices(int value)
        {
            int coincidences = 0; //совпадения
            foreach (int dice in tableDices)
            {
                if(dice == value) coincidences++;
            }

            Console.WriteLine("на столе " + coincidences + " " + value);
        }
    }
}
