using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    private bool isMovingForward = true;
    [SerializeField] private Vector3 APoint, BPoint;
    [SerializeField] private Transform a, b;

    private Rigidbody rb;
    [SerializeField] private float speed = 10f;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Start()
    {
        
    }
    private void Update()
    {
        MoveAndPause();
    }
    private void MoveAndPause()
    {
        APoint = a.position;
        BPoint = b.position;
        
        Vector3 targetPosition = isMovingForward ? APoint : BPoint;

        //Ex2
        //transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);

        transform.Translate((targetPosition - transform.position) * speed * Time.deltaTime);
        //rb.velocity = (targetPosition - transform.position) * speed * Time.deltaTime;

            // Check if the object has reached the target position.
        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            isMovingForward = !isMovingForward; // Toggle direction
        }
            
        }
        

        

    
}
