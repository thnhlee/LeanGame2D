using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
[AddComponentMenu("ThinhLe/PlayerController")]
public class PlayerController : MonoBehaviour
{
    [Header("Public")]
    public LayerMask groundLayer;
    [Header("Private")]
    [SerializeField] Transform groundCheck;
    [SerializeField] float moveSpeed = 5.0f;
    [SerializeField] float jumpForce = 5.0f;
    [SerializeField] float radius = 0.5f;
    private Rigidbody2D rb;
    bool isGround = false;
    bool facingRight = true;
    private Animator anim;
    private int isWalkId;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        isWalkId = Animator.StringToHash("IsWalk");
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (IsGround() && Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }

    }

    bool IsGround()
    {
        bool isLocalGround = Physics2D.OverlapCircle(groundCheck.position, radius, groundLayer);
        return isLocalGround;
    }

    private void jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * moveSpeed, rb.velocity.y);
        if (horizontal > 0 && !facingRight || (horizontal < 0 && facingRight))
        {
            Flip();
        }

        // thay animation từ đứng im -> di chuyển
        if(Math.Abs(horizontal) > 0)
        {
            anim.SetBool(isWalkId, true);
        }
        else
        {
            anim.SetBool(isWalkId, false);
        }
    }

    private void Flip()
    {
        facingRight =!facingRight;
        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;  
    }
}
