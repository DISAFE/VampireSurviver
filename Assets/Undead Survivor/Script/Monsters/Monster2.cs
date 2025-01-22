using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Monster2 : MonoBehaviour
{
    private Rigidbody2D monsterRigidbody;
    private Animator animator;
    private SpriteRenderer monsterRendering;

    private float normalSpeed = 125.0f;
    private Vector2 monsterInput;
    

    // Start is called before the first frame update
    void Start()
    {
        monsterRigidbody = GetComponent<Rigidbody2D>();
        monsterRendering = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Walk();
    }

    void LateUpdate()
    {
        if (monsterInput.x != 0)
        {
            monsterRendering.flipX = monsterInput.x < 0;
        }
    }

    void Walk()
    {
        Vector3 playerPos = PlayerManager.Instance.player.transform.position;
        monsterInput.x = playerPos.x - transform.position.x;
        monsterInput.y = playerPos.y - transform.position.y;
        monsterInput = monsterInput.normalized * normalSpeed * Time.fixedDeltaTime;
        monsterRigidbody.velocity = monsterInput;
    }
}
