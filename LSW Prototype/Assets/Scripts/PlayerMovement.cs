using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;

    public GameObject pauseScreen;

    //currency
    public static float coins = 90;
    void Update()
    {
        //Input values for x and y
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Clamp for diagonal move speed = horizontal/vertical move speed
        movement = Vector2.ClampMagnitude(movement, 1f);

        //Animator values
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("moveSpeed", movement.sqrMagnitude);

        //Options menu
        if(Input.GetKey(KeyCode.Escape))
        {
            pauseScreen.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
