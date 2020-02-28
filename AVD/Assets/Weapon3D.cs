using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon3D : MonoBehaviour
{

    public Transform firePoint1;
    public Transform firePoint2;
    public Transform firePoint3;
    public Transform firePoint4;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
        Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
        Instantiate(bulletPrefab, firePoint3.position, firePoint3.rotation);
        Instantiate(bulletPrefab, firePoint4.position, firePoint4.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {

    }
}
