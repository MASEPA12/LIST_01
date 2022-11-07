using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NINE : MonoBehaviour

{   //VARIABLE DECLARATION
    public int numOfCandy;
    public int numOfPeople;
    private int candiesPerPerson;
    private int candiesLeft;

    void Start()
    {
        candiesPerPerson = numOfCandy / numOfPeople; //Division to achieve candies per person
        candiesLeft = numOfCandy % numOfPeople; //Module to achieve candies left

        Debug.Log($"If we have {numOfCandy} candies and {numOfPeople} persons, each person should have {candiesPerPerson} candies and there are left {candiesLeft} candies.");
    }
}
