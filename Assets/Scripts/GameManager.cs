using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("UI Settings")]
    public GameObject scorePanel;
    public GameObject gameOverPanel;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        scorePanel.SetActive(false);
        gameOverPanel.SetActive(true);
    }

}
