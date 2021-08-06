using System;

///<summary>Public Class for Player</summary>
class Player
{
    ///<summary> Private classes </summary>
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

    ///<summary> Protptype prints health</summary>
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
    }

	public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;        
    }
}
