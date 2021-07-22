using System;

namespace Enemies
{
    ///<summary>Rerpresents Zombie class</summary>
    class Zombie
    {
		///<summary>Zombie health field</summary>
        public int health;

		///<summary>Zombie public constructor</summary>
        public Zombie()
        {
            health = 0;
        }
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                this.health = value;
            }
        }
    }
}