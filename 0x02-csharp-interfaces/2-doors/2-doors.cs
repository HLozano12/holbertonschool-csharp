using System;

///<summary> Base class</summary>
abstract class Base
{
    ///<summary> public property</summary>
    public string name { get; set; }

    ///<summary> Overiding ToString</summary>
    public override string ToString()
    {
        return (this.name + " is a " + this.GetType().ToString());
    }
}
///<summary> Public Interface </summary>
interface IInteractive
{
    void Interact();
}
///<summary> Public interface </summary>
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
///<summary> inherit from base </summary>
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