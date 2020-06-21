using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{

    // OnTriggerEnter2D вызывается, когда Collider2D входит в триггер (только двухмерная физика)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
    }


}
