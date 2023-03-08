using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism");

            EnemyManager enemyManager = new EnemyManager();


            while(true)
            {
                enemyManager.Draw();
                //
                //
                enemyManager.Update();
            }

            Console.ReadKey(true);
        }
    }
}
