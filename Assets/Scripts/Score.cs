using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [Header("UI Settings")]
    public Text panelScoreText;
    public Text panelHighScoreText;

    public static int score;
    int highScore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        highScore = PlayerPrefs.GetInt("highScore");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString();
        panelScoreText.text = score.ToString();
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("highScore", highScore);
            panelScoreText.text = highScore.ToString();
        }
    }
}
