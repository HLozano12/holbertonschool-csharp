using System;


///<summary>Player Class</summary>
class Player
{
    ///<summary> Private Class </summary>
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }
    private  string  status { get; set; }

    public event EventHandler<CurrentHPArgs> HPCheck;

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
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

	///<summary> Max Health Check </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
        {
            this.status = $"{this.name} is in perfect health!";
        }
        else if (e.currentHp >= (this.maxHp / 2))
        {
            this.status = $"{this.name} is doing well!";
        }
        else if (e.currentHp >= (this.maxHp / 4))
        {
            this.status = $"{this.name} isn't doing too great...";
        }
        else if (e.currentHp > 0)
        {
            this.status = $"{this.name} needs help!";
        }
        else
        {
            this.status = $"{this.name} is knocked out!";
        }
        Console.WriteLine(this.status);
    }

    ///<summary> prints health</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

	///<summary> Calculate Health </summary>
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
        HPCheck(this, new CurrentHPArgs(this.hp));
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

class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;
    public  CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
    
}
enum Modifier
{
    Weak,
    Base,
    Strong
}
delegate float CalculateModifier(float baseValue, Modifier modifier);