using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Score script;
    public Text score;
    public Text finalScore;
    public GameObject UI;
    // Start is called before the first frame update
    void Update()
    {
        if (UI.activeSelf)
        {

            finalScore.text = score.text;
            script.enabled = false;
        }
    }

}
