using System;
using System.Collections.Generic;
///<summary>Base abstract class</summary>
abstract class Base
{
    public string name = "";

    public override string ToString() => $"{this.name} is a {this.GetType()}";
}

interface IInteractive
{
    void Interact();
}
interface IBreakable
{
    int durability {get; set;}
    void Break();
}
interface ICollectable
{
    bool isCollected {get; set;}
    void Collect();
}
class Door : Base, IInteractive
{
    public Door(string name="Door")
    {
        this.name = name;
    }
    public void Interact()
    {
        System.Console.WriteLine($"You try to open the {this.name}. It's locked.");
        return;
    }
}

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability {get; set;}

    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    public void Interact()
    {
        if (this.durability < 0)
        {
            System.Console.WriteLine($"The {this.name} has been broken.");
            return;
        }
        if (isQuestItem == true)
        {
            System.Console.WriteLine($"You look at the {this.name}. There's a key inside.");
            return;
        }
        else
        {
            System.Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }
    public void Break()
    {
        this.durability--;
        if (this.durability > 0)
        {
            System.Console.WriteLine($"You hit the {this.name}. It cracks.");
            return;
        }
        if (this.durability == 0)
        {
            System.Console.WriteLine($"You smash the {this.name}. What a mess.");
            return;
        }
        if (this.durability < 0)
        {
            System.Console.WriteLine($"The {this.name} is already broken.");
            return;
        }
    }
}

class Key : Base, ICollectable
{
    public bool isCollected {get; set;}
    public Key(string name="Key", bool isCollected=false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
    public void Collect()
    {
        if (this.isCollected == false)
        {
            this.isCollected = true;
            System.Console.WriteLine($"You pick up the {this.name}.");
        }
        else
        {
            System.Console.WriteLine($"You have already picked up the {this.name}.");
        }
    }
}
class RoomObjects
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base thing in roomObjects)
        {
            if (type == typeof(IInteractive) && thing is IInteractive)
                ((IInteractive)thing).Interact();
            if (type == typeof(IBreakable) && thing is IBreakable)
                ((IBreakable)thing).Break();
            if (type == typeof(ICollectable) && thing is ICollectable)
                ((ICollectable)thing).Collect();
        }
    }
}
