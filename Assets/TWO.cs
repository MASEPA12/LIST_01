using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TWO : MonoBehaviour
{
    //VARIABLE DECLARATION
    public string name;
    public string cityName;
    
    void Start()
    {   //showing the message to the console
        Debug.Log($"Hello, {name}! Welcome to {cityName}.");
    }
}
