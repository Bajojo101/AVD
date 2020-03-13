using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTurret : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject turret;
    public GameObject ball;
    public LayerMask layermask;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void Die()
    {
        Destroy(gameObject);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (layermask == (layermask | (1 << collision.gameObject.layer)))
        {

            Instantiate(turret, collision.contacts[0].point, Quaternion.identity, transform.parent);           
            Die();
        }
        else
        {
            GetComponent<Animator>().SetTrigger("Failure");
        }
        rb.Sleep();
    }
    
}
