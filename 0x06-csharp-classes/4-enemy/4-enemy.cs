using System;

namespace Enemies
{
    ///<summary>Zombie class</summary>
    class Zombie
    {
		///<summary>Class Private field</summary>
        public int health;
        private string name = "(No name)";
        public Zombie()
        {
            health = 0;
        }
		///<summary>public constructor with a value</summary>
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

        public string Name
        {
            get {return (name);}
            set {name = value;}
        }

        public int GetHealth()
        {
            return health;
        }
    }
}