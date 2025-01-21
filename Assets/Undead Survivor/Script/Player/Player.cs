using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    private Camera mainCamera;
    private SpriteRenderer playerRendering;
    private Animator animator;

    private float normalSpeed = 200.0f;
    private Vector2 playerInput;
   

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        mainCamera = GetComponentInChildren<Camera>();
        playerRendering = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Walk();
    }
    void LateUpdate()
    {
        animator.SetFloat("Speed", playerInput.magnitude);

        if (playerInput.x != 0)
        {
            playerRendering.flipX = playerInput.x < 0;
        }
    }

    void Walk()
    { 
        playerInput.x = Input.GetAxisRaw("Horizontal");
        playerInput.y = Input.GetAxisRaw("Vertical");
        playerInput = playerInput.normalized;
        playerInput = playerInput * normalSpeed * Time.fixedDeltaTime;
        playerRigidbody.velocity = playerInput;
    }

}
