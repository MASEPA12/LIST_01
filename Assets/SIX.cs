using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIX : MonoBehaviour
{
    // VARIABLE DECLARATION
    public int dayOfTheWeek;

    void Start()
    {       //if the number of the day is 1,2,3,4,5 it doesn't belongs to the weekend
        if(dayOfTheWeek == 1 || dayOfTheWeek == 2 || dayOfTheWeek == 3 || dayOfTheWeek == 4 || dayOfTheWeek == 5)
        {
           Debug.Log($"Day {dayOfTheWeek} does not belongs to weekend");        
        }   //otherwise, if the number of the day is 6 or 7, it belongs
        else if(dayOfTheWeek == 6 || dayOfTheWeek == 7)  
        {   
            Debug.Log($"Day {dayOfTheWeek} belongs to weekend");      
        }
    }
}
