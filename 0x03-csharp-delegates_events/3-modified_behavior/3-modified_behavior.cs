using System;


///<summary>Player Class</summary>
class Player
{
    ///<summary> Private Classes </summary>
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }

    ///<summary> constructor for the player stats</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
        {
            this.maxHp = maxHp;
        }

        this.name = name;
        this.hp = this.maxHp;
    }

    ///<summary> prints health</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    delegate void CalculateHealth(float health);
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            damage = 0f;
            System.Console.WriteLine("{0} takes 0 damage!", this.name);
        }
        else
        {
            System.Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        }
        this.hp -= damage;
        ValidateHP(this.hp);
    }
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            heal = 0f;
            System.Console.WriteLine("{0} heals 0 HP!", this.name);
        }
        else
        {
            System.Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        }
        this.hp += heal;
        ValidateHP(this.hp);
    }

    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
        {
            this.hp = 0f;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }

        public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue / 2;
        else if (modifier == Modifier.Strong)
            return baseValue * 1.5f;
        else
            return baseValue;
    }

}

enum Modifier
{
    Weak,
    Base,
    Strong
}
delegate float CalculateModifier(float baseValue, Modifier modifier);