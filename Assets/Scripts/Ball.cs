using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D ball;
    public float bounceForce;
    private bool gameStarted = false;

    private void Awake()
    {
        ball = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            if (Input.anyKeyDown)
            {
                gameStarted = true;
                bounce();
                GameManager.instance.startMenu.SetActive(false);
                GameManager.instance.scoreObject.SetActive(true);
            }
        }
    }

    void bounce()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);

        ball.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paddle")
        {
            GameManager.instance.increaseScore();
        }

        if (collision.gameObject.tag == "FallCheck")
        {
            GameManager.instance.restart();
        }
    }

}
