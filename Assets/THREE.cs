using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THREE : MonoBehaviour
{
    //VARIABLE DECLARATION
    public string name;
    public int playerAge;

    void Start()
    {   //showing the message to the console 
        Debug.Log($"“Hello, {name}! You are {playerAge} years old.");
    }

 }
