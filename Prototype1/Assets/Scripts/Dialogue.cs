using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //so we see the class in the inspector and edit it
public class Dialogue
{
    public string name;
    //public int num;
    //public int optionNum = -1; //can reset

    [TextArea(3,10)]
    public string[] sentences;
    [TextArea(3, 10)]
    public string[] sentences1;
    [TextArea(3, 10)]
    public string[] sentences2;
    [TextArea(3, 10)]
    public string[] sentences3;

    public string[] options;

    //option1
    [TextArea(3, 10)]
    public string[] sentences4;
    [TextArea(3, 10)]
    public string[] sentences5;
    [TextArea(3, 10)]
    public string[] sentences6;
    [TextArea(3, 10)]
    public string[] sentences7;

    //option2
    [TextArea(3, 10)]
    public string[] sentences8;
    [TextArea(3, 10)]
    public string[] sentences9;
    [TextArea(3, 10)]
    public string[] sentences10;
    [TextArea(3, 10)]
    public string[] sentences11;

    //option3
    [TextArea(3, 10)]
    public string[] sentences12;
    [TextArea(3, 10)]
    public string[] sentences13;
    [TextArea(3, 10)]
    public string[] sentences14;
    [TextArea(3, 10)]
    public string[] sentences15;
}
