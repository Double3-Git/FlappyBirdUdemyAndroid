using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    [Header("System settings")]
    public int poolSize = 5;
    public GameObject column;

    [HideInInspector]
    public List<GameObject> pooledColumns;
    public static ColumnPool SharedInstance;

    // Метод Awake вызывается во время загрузки экземпляра сценария
    private void Awake()
    {
        SharedInstance = this;
    }

    // Метод Start вызывается перед первым вызовом какого-либо метода Update
    private void Start()
    {
        GameObject poolContainer = new GameObject("Pool Container");
        poolContainer.transform.position = Vector2.zero;

        pooledColumns = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < poolSize; i++)
        {
            tmp = Instantiate(column, poolContainer.transform);
            tmp.SetActive(false);
            
            pooledColumns.Add(tmp);
        }
    }


}
