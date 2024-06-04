using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    [SerializeField] private float jumpForce = 5.0f;
    [SerializeField] private float gravityModifier = 2.0f;
    [SerializeField] private bool isOnGround = true;
    [SerializeField] private bool gameOver = false;
    private Rigidbody2D playerRb;
    private bool canJump = false;

    private Vector2 movement;
    private float xMovement;


    public LayerMask ground;
    //ground check should be a child of the player
    public Transform groundCheck;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
        //anim.Play("Idle");
        //set gravity
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        CheckGround();
        CheckJump();

    }

    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        xMovement = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            canJump = true;
        }
    }

    void Move()
    {
        playerRb.velocity = new Vector2(xMovement * speed, playerRb.velocity.y);
    }

    void CheckJump()
    {
        if (canJump)
        {
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            canJump = false;
        }
        if (!canJump)
        {
            playerRb.AddForce(Vector2.down * .2f, ForceMode2D.Impulse);
            
        }
    }




    void CheckGround()
    {
        Collider2D col = Physics2D.OverlapCircle(groundCheck.position, 1.5f, ground);
        if (col == null)
        {
            isOnGround = false;
            //anim.Play("Jump");
            //Debug.Log("Not On Ground");
        }
        else
        {
            isOnGround = true;
            //Debug.Log("On Ground");
            //anim.Play("Idle");
        }
    }
}


