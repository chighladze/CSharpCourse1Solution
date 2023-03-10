using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class Character
    {
        //public - anywhere
        //internal - only in project
        //private - default
        //protected - oonly in the class and in its descendants


        private int health = 100;

        public int Health
        {
            get
            {
                return health;
            }
            private set
            {
                health = value;
            }
        }

        public void Hit(int damage)
        {
            if (damage > Health)
            {
                damage = Health;
            }
            Health -= damage;
        }
    }
}
