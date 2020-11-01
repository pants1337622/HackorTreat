using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;
    private bool facingRight = true;
    public float checkRadius;
    public LayerMask whatIsGround;
    private bool isGrounded;
    public Transform groundCheck;
    public List<GameObject> inventory = new List<GameObject>();
    public RoomManager roomscript;
    public LayerMask whatIsLadder;
    public float distance;
    public bool isClimbing;
    public Animator animator;
    public AudioSource[] soundeffects;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public static void ShiftRight<T>(List<T> lst, int shifts)
    {
        for (int i = lst.Count - shifts - 1; i >= 0; i--)
        {
            lst[i + shifts] = lst[i];
        }

        for (int i = 0; i < shifts; i++)
        {
            lst[i] = default(T);
        }
    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxis("Horizontal");
        Debug.Log(moveInput);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        animator.SetBool("Run", true);
        if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
        else if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsLadder);
        if(hitInfo.collider != null)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                isClimbing = true;
                animator.SetBool("Climb", true);
            }
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                isClimbing = false;
            }
        }

        if(isClimbing == true && hitInfo.collider != null)
        {
            var inputVertical = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, inputVertical * speed);
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = 5;
            animator.SetBool("Climb", false);
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            animator.SetBool("Jump", true);
            soundeffects[0].Play();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShiftRight(inventory, 1);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            if(inventory[0] == GameObject.Find("Boostgem"))
            {
                if(facingRight == false)
                {
                    rb.velocity = Vector2.left * jumpForce;
                }
                else
                {
                    rb.velocity = Vector2.right * jumpForce;
                } 
            }
            if(inventory[0] == GameObject.Find("Teleporter"))
            {
                roomscript.Home();
                this.transform.position = new Vector3(0, 0, 0);
            }
            if(inventory[0] == GameObject.Find("Paintbrush"))
            {
                if(this.gameObject.GetComponent<TrailRenderer>().enabled == true)
                {
                    this.gameObject.GetComponent<TrailRenderer>().enabled = false;
                }
                else
                {
                    this.gameObject.GetComponent<TrailRenderer>().enabled = true;
                }
                
            }
            if (inventory[0] == GameObject.Find("Feather"))
            {
                rb.velocity = Vector2.up * jumpForce;
            }
        }
        if(this.transform.position.x <= -6.5)
        {
            Vector3 pos = this.transform.position;
            pos.x = this.transform.position.x + 12;
            this.transform.position = pos;
            roomscript.MoveLeft();
        }
        if(this.transform.position.x >= 6.5)
        {
            Vector3 pos = this.transform.position;
            pos.x = this.transform.position.x - 12;
            this.transform.position = pos;
            roomscript.MoveRight();
        }
        if(this.transform.position.y >= 4.5)
        {
            Vector3 pos = this.transform.position;
            pos.x = this.transform.position.y - 8;
            this.transform.position = pos;
            roomscript.MoveUp();
        }
        if (this.transform.position.y <= -4.5)
        {
            Vector3 pos = this.transform.position;
            pos.x = this.transform.position.y + 8;
            this.transform.position = pos;
            roomscript.MoveDown();
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "item")
        {
            inventory.Add(collision.gameObject);
            collision.gameObject.SetActive(false);
            collision.gameObject.GetComponent<Show>().show = false;
            soundeffects[1].Play();
        }
    }
}
