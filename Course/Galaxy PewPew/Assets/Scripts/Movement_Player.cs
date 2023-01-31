using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Player : MonoBehaviour
{
    public float speed = 50f;
    
    // Called before the first frame
    void Start()
    {
        print("Movement_Player initialized");
    }

    // Update is called once per frame
    void Update()
    {
        var in_horizontal = Input.GetAxis("Horizontal");
        var in_vertical = Input.GetAxis("Vertical");
        var outofbounds_right = transform.position.x > 10;
        var outofbounds_left = transform.position.x < -10;
        
        if (in_horizontal != 0)
        {
            transform.Translate(Vector3.right * (speed * in_horizontal * Time.deltaTime));
        }
        if (in_vertical != 0)
        {
            transform.Translate(Vector3.up * (speed * in_vertical * Time.deltaTime));
        }

        if (outofbounds_right)
        {
            transform.Translate(new Vector3(-19f, 0, 0));
        }
        if(outofbounds_left)
        {
            transform.Translate(new Vector3(19f, 0, 0)); 
        }
    }
}
