using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEN : MonoBehaviour
{
    //VARIABLE DECLARATION
    public int tableOf = 2;

    void Start()
    {   //print the predeterminate multiplications with the operation in {} 
        Debug.Log($"{tableOf} x 1 = {tableOf}.");
        Debug.Log($"{tableOf} x 2 = {tableOf * 2}. ");
        Debug.Log($"{tableOf} x 3 = {tableOf * 3}. ");
        Debug.Log($"{tableOf} x 4 = {tableOf * 4}. ");
        Debug.Log($"{tableOf} x 5 = {tableOf * 5}. ");
        Debug.Log($"{tableOf} x 6 = {tableOf * 6}. ");
        Debug.Log($"{tableOf} x 7 = {tableOf * 7}. ");
        Debug.Log($"{tableOf} x 8 = {tableOf * 8}. ");
        Debug.Log($"{tableOf} x 9 = {tableOf * 9}. ");
        Debug.Log($"{tableOf} x 10 = {tableOf * 10}. ");
    }
}
