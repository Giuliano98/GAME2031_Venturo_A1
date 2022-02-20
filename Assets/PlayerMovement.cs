using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2500f;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    } 

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            moveLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveRight();
        }
    }

    public void moveLeft()
    {
        rb.AddForce(new Vector2(-1f * speed, 0f));
    }

    public void moveRight()
    {
        rb.AddForce(new Vector2( +1f * speed, 0f));
    }

}
