using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Enemy
    {

        public virtual void Update()
        {
            Console.WriteLine("Enemy is moving....");
        }

        public void Draw()
        {

        }
    }
}
