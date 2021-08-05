using System;

///<summary> Base class</summary>
abstract class Base
{
    ///<summary> public property</summary>
    public string name { get; set; }

    ///<summary>method that overrides ToString</summary>
    public override string ToString()
    {
        return (this.name + " is a " + this.GetType().ToString());
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class Door : Base, IInteractive
{
    public Door(string name ="Door")
    {
        this.name = name;
    }
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}

class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; }
    public bool isQuestItem;
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    public void Interact()
    {
        if (durability < 0)
        {
            Console.WriteLine("The {0} has been broken.", this.name);
        }
        else
        {
            if (isQuestItem is true)
            {
                Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
            }
            else
            {
                Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
            }
        }
    }
    public void Break()
    {
        durability--;
        if (durability > 0)
        {
            Console.WriteLine("You hit the {0}. It cracks.", this.name);
        }
        else if (durability == 0)
        {
            Console.WriteLine("You smash the {0}. What a mess.", this.name);
        }
        else
        {
            Console.WriteLine("The {0} is already broken.", this.name);
        }
    }
}