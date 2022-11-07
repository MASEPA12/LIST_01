using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONE : MonoBehaviour
{
    //VARIABLE DECLARATION
    public float variable1 = 5;
    public float variable2 = 3;
    public float variable3 = 9;
    public float result;

   
    void Start()
    {   //setting the value of "result" and showing it to console
        result = variable1 + variable2 + variable3;
        Debug.Log($"The sum of {variable1}, {variable2} and {variable3} is {result}.");
    }
}
