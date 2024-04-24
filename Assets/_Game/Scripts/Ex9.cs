using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex9 : MonoBehaviour
{
    private Vector3 initialPosition;
    private Vector3 targetPosition;

    private void Start()
    {
        initialPosition = transform.position;
        targetPosition = new Vector3(100f, 0f, 0f); // Set your desired target position
        MoveAndPause();
    }

    private void MoveAndPause()
    {
        // Move to the target position
        float duration = 1.0f;
        float elapsedTime = 0f;
        if (elapsedTime < duration)
        {
            //transform.Translate((targetPosition - transform.position) * speed * Time.deltaTime);
            //transform.position = Vector3.Lerp(initialPosition, targetPosition, 1);
            transform.Translate((targetPosition - initialPosition) * Time.deltaTime);
            elapsedTime += Time.deltaTime;
            
        }

        

        
        
    }
}
