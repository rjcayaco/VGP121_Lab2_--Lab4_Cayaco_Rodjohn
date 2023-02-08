using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeedY;
    public float playerSpeedX;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerSpeedY <= 0)
        {
            playerSpeedY = 12.0f;
            Debug.Log("Speed was set incorrect, deafaulting to " + playerSpeedY.ToString());

        }
        if (playerSpeedX <= 0)
        {
            playerSpeedX = 10.0f;
            Debug.Log("Speed was set incorrect, deafaulting to " + playerSpeedX.ToString());
        }

        ProcessInputs();
       

    }

    void FixedUpdate()
    {
        Move();
        
    }

    void ProcessInputs()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        float directionX = Input.GetAxisRaw("Horizontal");
        playerDirection = new Vector2(directionX, directionY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(playerDirection.x *playerSpeedX, playerDirection.y * playerSpeedY);
    }
}
