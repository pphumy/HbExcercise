using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the input
        var input = Input.inputString;
        //ignore null input to avoid unnecessary computation
        if (!string.IsNullOrEmpty(input))
            //logic related to the char pressed
            Debug.Log("Pressed char: " + Input.inputString);
    }

}


