using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody body;

    float horizontal;
    float vertical;
   public float moveLimiter = 0.7f;
    
    public float runSpeed = 20.0f;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        vertical = Input.GetAxisRaw("Vertical"); // -1 is down
    }
    public bool SpeedTooFast(float speed)
    {
        if (speed > 1)
        {
            Debug.Log("Unexpected value. Horizontal speed too high");
            return true;
        }
        else return false;
           
       
    }

    public bool LimiterBreak(float speed)
    {
        if (speed > 1)
        {
            Debug.Log("Unexpected value. Speed beyond the speed limit");
            return true;
        }
        else return false;


    }
    void FixedUpdate()
    {
        

        if (horizontal != 0 && vertical != 0) 
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        body.velocity = new Vector3(horizontal * runSpeed, 0, vertical * runSpeed);
    }
}
