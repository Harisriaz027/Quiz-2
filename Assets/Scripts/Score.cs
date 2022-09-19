using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public TMP_Text text;
    public static float score;
    void Start()
    {
        score = 0;
    }

    
    void Update()
    {

        text.text = score.ToString("Score: " + score);
    }
}
