using System;

/// <summary>Delegate for health levels</summary>
public delegate void CalculateHealth(float f);

/// <summary>Delegate for Modification</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>Enum for Players</summary>
public enum Modifier
{
    /// <summary>weak aginst</summary>
    Weak,
    /// <summary>Base modifier</summary>
    Base,
    /// <summary>strong aginst</summary>
    Strong
}

/// <summary>class Player</summary>
public class Player
{
    /// <summary>Private class Player</summary>
    private string name { get; set; }
    
    private float maxHp { get; set; }
    
    private float hp { get; set; }

    private string status { get; set; }

    /// <summary>Event Handler</summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>Player constructor</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
           System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
           maxHp = 100f;
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
        this.status = $"{name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>Prints health</summary>
    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>Method for CalculateHealth</summary>
    public void TakeDamage(float damage)
    {
        
        if (damage < 0.0f)
        {
            System.Console.WriteLine($"{name} takes 0 damage!");
        }
        else
            System.Console.WriteLine($"{name} takes {damage} damage!");
        hp -= damage;
        ValidateHP(hp);
    }

    /// <summary>Method that follows CalculateHealth</summary>
    public void HealDamage(float heal)
    {
        
        if (heal < 0.0f)
        {
            System.Console.WriteLine($"{name} heals 0 HP!");
        }
        else
        {
            System.Console.WriteLine($"{name} heals {heal} HP!");
            hp += heal;
        }
        ValidateHP(hp);
    }

    /// <summary>sets the new value of the Player’s health.</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
        OnCheckStatus(new CurrentHPArgs(hp));
    }

    /// <summary>Method that modifies the damage multiplyer.</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier is Modifier.Weak)
            return baseValue *= 0.5f;
        if (modifier is Modifier.Strong)
            return baseValue *= 1.5f;
        else
            return baseValue;
    }
    /// <summary>Method for setting players status.</summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            System.Console.WriteLine($"{this.name} is in perfect health!");
        }
        else if (e.currentHp >= (maxHp * 0.5))
        {
            System.Console.WriteLine($"{this.name} is doing well!");
        }
        else if (e.currentHp < (maxHp * 0.5) && e.currentHp >= (maxHp * 0.25))
        {
            System.Console.WriteLine($"{this.name} isn't doing too great...");
        }
        else if (e.currentHp < (maxHp * 0.25) && e.currentHp > 0.0f)
        {
            System.Console.WriteLine($"{this.name} needs help!");
        }
        else if (e.currentHp == 0)
        {
            System.Console.WriteLine($"{this.name} is knocked out!");
        }
    }
    /// <summary>Method for HPwarning events.</summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Health is low!");
        }
        Console.ResetColor();
    }

    /// <summary>Method Check status.</summary>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        CheckStatus(HPCheck, new CurrentHPArgs(hp));

        if (e.currentHp <= (maxHp * 0.25))
        {
            HPValueWarning(HPCheck, new CurrentHPArgs(hp));
        }
    }
}

/// <summary>Class that inherits from EventArgs</summary>
public class CurrentHPArgs :  EventArgs
{
    /// <summary>Read-only public float</summary>
    public readonly float currentHp;

    /// <summary>Public Constructor</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}