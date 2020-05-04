using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //so we see the class in the inspector and edit it
public class Dialogue 
{
    public string name;

    [TextArea(3,10)]
    public string[] sentences;
}
