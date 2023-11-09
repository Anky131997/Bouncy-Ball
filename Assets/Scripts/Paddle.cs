using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    Rigidbody2D paddle;
    public float movespeed;

    // Start is called before the first frame update
    void Start()
    {
        paddle = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touchPos.x < 0)
            {
                paddle.velocity = Vector2.left * movespeed;
            }
            else if (touchPos.x > 0)
            {
                paddle.velocity = Vector2.right * movespeed;
            }
        }
        else
        {
            paddle.velocity = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        TouchMove();
    }
}
