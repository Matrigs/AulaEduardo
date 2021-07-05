using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class PlayerController : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed;
    public float horizontalMove;
    public bool crouch;
    public bool jump;
    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI energyText;
    public int points;
    public int energy;
    public GameManager gamemanager;
    public bool pause = false;
    

    void Start()
    {
        pointsText.text = "Points: " + points;

        energyText.text = "Energy: " + energy;

        gamemanager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void Update()
    {
        //Debug.Log(Input.GetAxisRaw("Horizontal"));
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed",Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("Jumping", true);
        }

        if (Input.GetButtonDown("Crouch")&& controller.m_Grounded)
        {
            crouch = true;
            animator.SetBool("Crouch", true);
        }
        else if (Input.GetButtonUp("Crouch") && controller.m_Grounded)
        {
            crouch = false;
            animator.SetBool("Crouch", false);
        }

        if (controller.m_Grounded) 
        { 
            animator.SetBool ("Jumping", false); 
        }

        if (Input.GetKeyDown(KeyCode.Escape) && pause == false)
        {
            pause = true;
            gamemanager.Pause();
        } else if (Input.GetKeyDown(KeyCode.Escape) && pause == true)
        {
            pause = false;
            gamemanager.Despause();
        }



    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "item")
        {
            points += other.GetComponent<itemController>().points;
            pointsText.text = "Points: " + points;
            energy += other.GetComponent<itemController>().energy;
            energyText.text = "Energy: " + energy;
           
            Destroy(other.gameObject);
        }
        if (other.tag == "Enime")
        {
            energy -= other.GetComponent<Eagle>().damage;
            energyText.text = "Energy: " + energy;


        }
    }

}