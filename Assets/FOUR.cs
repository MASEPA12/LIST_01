using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOUR : MonoBehaviour
{
    // VARIABLE DECLARATION
    public int yearOfBirth;
    public int actualYear;
    private int playerAge;

    void Start()
    {
        Debug.Log($"The year you born is {yearOfBirth} and now we are in {actualYear}."); 
        playerAge = actualYear - yearOfBirth; //saving the the value of the person’s age
        Debug.Log($"If we are in the year {actualYear} and you were born in {yearOfBirth}, you are {playerAge} years old.");
    }
}
