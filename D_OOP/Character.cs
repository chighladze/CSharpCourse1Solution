using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class Character
    {
        private static int speed = 10;

        public int Health { get; set; } = 100;

        public void Hit(int damage)
        {
            if (damage > Health)
            {
                damage = Health;
            }

            Health -= damage;
        }


        public int PrintSpeed()
        {
            return speed;
        }

        public void IncreaseSpeed()
        {
            speed += 10;
        }

    }
}
