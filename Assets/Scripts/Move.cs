using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("UX Settings")]
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.left * speed * Time.deltaTime;

        // We need to deactivate the Invisible object to supor pooling
        if (tag == "Column" && transform.position.x < -3f)
            gameObject.SetActive(false);
    }
}
