using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header("Game setup")]
    public GameObject column;
    public float maxTime = 1.5f;
    public float minHeight = -.3f;
    public float maxHeight = 1.3f;

    // private zone
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newColumn = Instantiate(column);
        newColumn.transform.position = (Vector2)transform.position + Vector2.up * Random.Range(minHeight, maxHeight);
        Destroy(newColumn, 5);

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newColumn = Instantiate(column);
            newColumn.transform.position = (Vector2)transform.position + Vector2.up * Random.Range(minHeight, maxHeight);
            Destroy(newColumn, 5);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
