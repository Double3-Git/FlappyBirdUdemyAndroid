using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bird : MonoBehaviour
{
    [Header("System settings")]
    public GameManager gameManager;

    [Header("Player settings")]
    public float speed = 3f;

    // Private section
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.up * speed;
        }
    }

    // OnCollisionEnter2D вызывается, когда данный элемент collider2D или rigidbody2D касается 
    // другого элемента rigidbody2D или collider2D (только двухмерная физика)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }




}
