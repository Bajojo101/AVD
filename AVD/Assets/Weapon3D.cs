using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon3D : MonoBehaviour
{
    public float frequency = 1f;
    public float TimeAlive = 3f;
    public GameObject Bullet3d;
    public Transform[] BulletPositions;
    public Animator[] GunsAnimators;
    public Animator TurretAnimator;
    private int i = 0;
    void Start()
    {
       
        StartCoroutine(Fire());
        StartCoroutine(Disappear());
    }

    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(TimeAlive);
        TurretAnimator.SetTrigger("Die");
        yield return null;
        
    }

    public void KillTurret()
    {
        StopAllCoroutines();
        TurretAnimator.SetTrigger("Die");
    }

    public void Die()
    {
        Destroy(gameObject);
    }

  
    IEnumerator Fire()
    {
        GunsAnimators[i].SetTrigger("Fire");

        Instantiate(Bullet3d, BulletPositions[i].position, BulletPositions[i].rotation);
        i++;
        if (i >= BulletPositions.Length) i = 0;
        yield return new WaitForSeconds(frequency);

        StartCoroutine(Fire());
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
