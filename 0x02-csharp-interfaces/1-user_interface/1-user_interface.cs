using System;

///<summary> Base class</summary>
abstract class Base
{
    ///<summary> public name</summary>
    public string name { get; set; }

    ///<summary>overriding ToString</summary>
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

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Collect() {}
    public void Break() {}
    public void Interact() {}
}