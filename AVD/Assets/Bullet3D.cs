using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3D : MonoBehaviour
{
    public float speed = 100f;
    public float thrust = 1.0f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        //rb.AddForce(0, 0, thrust, ForceMode.Impulse);
        rb.AddForce(transform.position * speed);
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
