using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fibonacci : MonoBehaviour
{
    public Text fibNr;
    public int a;
    public int b;
    public int c;

    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        b = 1;
        c = 0;
    }

    // Update is called once per frame
    void Update()
    {
        fibNr.text = c.ToString();
    }

    void OnMouseUp()
    {
        c = fibonacciIncrement();
    }

    //Function to create the sequence
    public int fibonacciIncrement()
    {
        int prev = a; //Store the current number to prev number
        a = b; //a becomes the next number
        b = b + prev; //Increments the next number

        return a;
    }
}
