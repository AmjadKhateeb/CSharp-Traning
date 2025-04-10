using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assigment29;

public class CustomObject
{
    public int ID { get; set; }
    public string Name { get; set; }

    public CustomObject(int id, string name)
    {
        ID = id;
        Name = name;
    }
    public static bool operator ==(CustomObject a, CustomObject b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;
        return a.ID == b.ID && a.Name == b.Name;
    }

    public static bool operator !=(CustomObject a, CustomObject b)
    {
        return !(a == b);
    }


    public override int GetHashCode()
    {
        return ID.GetHashCode() ^ Name.GetHashCode();
    }

}
