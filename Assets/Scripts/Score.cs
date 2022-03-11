using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform snowball;
    public Text score;
    // Update is called once per frame
    void Update()
    {
            score.text = "Score: " + (snowball.localScale.x * 100 - 100).ToString("0");
    }
}
