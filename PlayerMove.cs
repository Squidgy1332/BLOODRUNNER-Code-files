using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private float walkSpeed = 100f;
    private float DySpeed = 0.7f;
    private float moveH;
    private float moveV;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal");
        moveV = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (moveV != 0f || moveH != 0f)
        {
            if(moveV != 0f && moveH != 0f) 
            {
                moveV *= DySpeed;
                moveH *= DySpeed; 
            }
  
            rb.velocity = new Vector2(moveH * walkSpeed * Time.deltaTime, moveV * walkSpeed * Time.deltaTime);
        }
        else
        {
 
            rb.velocity = new Vector2(0f, 0f);
        }
    }
}
