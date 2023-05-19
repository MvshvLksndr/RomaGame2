using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roma
{
    public class Program
    {
        
        
        public static void Main(string[] args)
        {
            Engine engine = new Engine();
            Console.WriteLine("введите количество игроков");
            int PlayersCount = Convert.ToInt32(Console.ReadLine());

            engine.InitPlayers(PlayersCount);
            engine.ThrowDices();
            Console.ReadLine();

            Console.WriteLine("На столе (введите номинал)");
            int DiceValue = Convert.ToInt32(Console.ReadLine());

            engine.CheckDices(DiceValue);

            Console.ReadLine();
        }
    }
}
