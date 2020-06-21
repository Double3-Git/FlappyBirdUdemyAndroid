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
        // Standart udemy decidion
        //GameObject newColumn = Instantiate(column);
        //newColumn.transform.position = (Vector2)transform.position + Vector2.up * Random.Range(minHeight, maxHeight);
        //Destroy(newColumn, 5);

        // Object pool style
        //GameObject newColumn = ColumnPool.SharedInstance.GetPooledObject();
        //newColumn.transform.position = (Vector2)transform.position + Vector2.up * Random.Range(minHeight, maxHeight);

        // Functional style
        CreateColumn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            // Standart udemy decidion
            //GameObject newColumn = Instantiate(column);
            //newColumn.transform.position = (Vector2)transform.position + Vector2.up * Random.Range(minHeight, maxHeight);
            //Destroy(newColumn, 5);

            // Object pool style
            //GameObject newColumn = ColumnPool.SharedInstance.GetPooledObject();
            //newColumn.transform.position = (Vector2)transform.position + Vector2.up * Random.Range(minHeight, maxHeight);

            // Functional style
            CreateColumn();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void CreateColumn()
    {
        GameObject newColumn = ColumnPool.SharedInstance.GetPooledObject();
        newColumn.transform.position = (Vector2)transform.position + Vector2.up * Random.Range(minHeight, maxHeight);
    }
}
