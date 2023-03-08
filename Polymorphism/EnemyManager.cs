using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class EnemyManager
    {

        Enemy[] enemies = new Enemy[3];

        public EnemyManager()
        {
            Enemy slime = new Slime();//polymorphism
            Enemy rat = new Rat();//polymorphism
            Enemy ogre = new Ogre();//polymorphism

            enemies[0] = slime;//polymorphism
            enemies[1] = rat;//polymorphism
            enemies[2] = ogre;//polymorphism
        }
        public void Update()
        {
            //update all enemies

            for(int i = 0; i < enemies.Length; i++)
            {
                //method 1
                Enemy enemy = enemies[i];
                enemy.Update();
            }
        }
        
        public void Draw()
        {
            //draws all enemies
            for(int i = 0; i< enemies.Length; i++)
            {
                Enemy enemy = enemies[i];
                enemy.Draw();
            }
        }
    }

}
