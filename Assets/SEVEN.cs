using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEVEN : MonoBehaviour
{
    // VARIABLE DECLARATION
    public string letter;

    void Start()
    {   
        if(letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {   //if the letter is some of the vowels, it is going to execut this:
            Debug.Log($"The {letter} is a vowel.");
        }
        else //if it's not, it's going to execut this:
        {
            Debug.Log($"The {letter} is a consonant.");
        }
    }

}
