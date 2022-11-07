using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EIGHT : MonoBehaviour
{
    /* 
     * 28 days - February
     * 30 days - April, june, septemper, november
     * 31 days - january, march, may, july, august, october, december
    */

    public string month;
    
    void Start()
    {   
        if (month == "February") //if the month is February, it will execute "28" days
        {   
            Debug.Log($"The month {month} has 28 days.");
        }
        else //if it's not February...
        {
            if(month == "April" || month == "June" || month == "September" || month == "November")
            {
                Debug.Log($"The month {month} has 30 days."); 
            }
            else if(month == "January" || month == "March" || month == "May" || month == "August" || month == "October" || month == "December")
            {
                Debug.Log($"The month {month} has 31 days."); 
            }
        }
    }
}
