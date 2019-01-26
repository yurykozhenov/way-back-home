using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float jumpForce;

    bool grounded;
    
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    Animator animator;

    void Start () 
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        var movement = new Vector3(horizontalMovement * speed, rb.velocity.y, 0.0f);
        
        rb.velocity = movement;
        animator.SetFloat("VelocityX", Mathf.Abs(rb.velocity.x));

        if (horizontalMovement > 0 && spriteRenderer.flipX)
        {
            spriteRenderer.flipX = false;
        } 
        else if (horizontalMovement < 0 && !spriteRenderer.flipX)
        {
            spriteRenderer.flipX = true;
        }

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0.0f, jumpForce, 0.0f), ForceMode2D.Impulse);
        }
        
        animator.SetBool("Jumping", Mathf.Abs(rb.velocity.y) > 0.01);
    }
}