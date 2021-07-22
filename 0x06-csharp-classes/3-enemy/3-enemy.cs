using System;

namespace Enemies
{
    ///<summary>Rerpresents Zombie class</summary>
    class Zombie
    {
        public int health;
        public Zombie()
        {
            health = 0;
		}
		///<summary>Zombie public constructor with a value</summary>
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

		///<summary>Zombie public method returning health value</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}