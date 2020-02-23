using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2D : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy2D enemy = hitInfo.GetComponent<Enemy2D>();
        Cherry cherry = hitInfo.GetComponent<Cherry>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        if (cherry)
        {
            cherry.Remove();
        }
            Destroy(gameObject);
       

        
    }
}
