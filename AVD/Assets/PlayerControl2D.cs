using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerControl2D : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public float Gravity2D = -30f;
    public Text countTextCherry;
    public Text countTextGem;
    private int countCherry;
    private int countGem;
    private void ChangeGravity(float g)
    {
    }

    private void Start()
    {
        Physics2D.gravity = new Vector2(0, Gravity2D);
        countGem = 0;
        countCherry = 0;
        SetCountGem();
        SetCountCherry();
    }

    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
           crouch = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
         animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Cherry cherry = hitInfo.GetComponent<Cherry>();
        Gem gem = hitInfo.GetComponent<Gem>();
        if (gem)
        {
            gem.Remove();
            countGem = countGem + 1;
           
            SetCountGem();
        }
        if (cherry)
        {
            cherry.Remove();
            countCherry = countCherry + 1;
           
            SetCountCherry();
        }


    }

    void SetCountCherry()
    {
        countTextCherry.text = "Cherries: " + countCherry.ToString();
    }
    void SetCountGem()
    {
        countTextGem.text = "Gems: " + countGem.ToString();
    }
}