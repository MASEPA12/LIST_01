using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIVE : MonoBehaviour
{
    //VARIABLE DECLARATION
    public int numberA;
    public int numberB;

    void Start()
    {
        if(numberA > numberB) //if A is greater than B it is going to execut the line I, and if is not, the line II
        { //line I
            Debug.Log($"{numberA} is grater than {numberB}.");
        }
        else
        { //line II
            Debug.Log($"{numberB} is grater than {numberA}.");
        }
    }
}
