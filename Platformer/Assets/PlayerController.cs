using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float jumpForce = 5.0f;
    private float gravityModifier = 2.0f;
    private bool isOnGround = true;
    private bool gameOver = false;
    private Rigidbody2D playerRb;

    private Vector2 movement;
    //private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        //set gravity
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            isOnGround = false;
            //playerAnim.SetTrigger("Jump_trig");

        }

        if(Input.GetButtonUp("Jump") && !isOnGround)
        {
            playerRb.AddForce(Vector3.down * jumpForce, ForceMode2D.Impulse);
        }

        movement = new Vector2(Input.GetAxis("Horizontal"), 0);
        
        playerRb.velocity = new Vector2(movement.x * speed, playerRb.velocity.y);

        

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        
    }
}


