using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float H;
    float V;
    private Rigidbody2D playerRb;
    public float Speed;
    public float Force;
    public float GravityModifier;
    public bool isOnGround = true;
    bool FlipPos;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics2D.gravity *= GravityModifier;
    }

    // Update is called once per frame
    void Update()
    {

        movmentLeftandRight();

        if (Input.GetKeyDown(KeyCode.UpArrow )&& isOnGround)
        {
            jump();
            isOnGround = false;
        }


        if(H != 0f)
        {
            Flip();
            anim.SetBool("Walking",true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }

        
        

    }

    void movmentLeftandRight()
    {
        H = Input.GetAxisRaw("Horizontal");
        V = Input.GetAxisRaw("Vertical");
        Vector2 pos = transform.position;

        pos.x += H * Speed * Time.deltaTime;
        transform.position = pos;
    }

    void jump()
    {
        playerRb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            isOnGround = true;
        
    }

    void Flip()
    {
        

        if ((H < 0f) && !FlipPos)
        {
            transform.Rotate(0, 180, 0);
            FlipPos = true;
        }

        if((H > 0f) && (FlipPos))
        {
            transform.Rotate(0, -180, 0);
            FlipPos = false;
        }
                
    }
}
