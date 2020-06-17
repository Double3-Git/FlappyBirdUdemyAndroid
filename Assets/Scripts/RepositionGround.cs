using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositionGround : MonoBehaviour
{

    BoxCollider2D boxCollider2D;
    float totalLenght;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        totalLenght = boxCollider2D.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -totalLenght)
        {
            transform.position = (Vector2)transform.position + Vector2.right * totalLenght * 2f;
        }
    }
}
