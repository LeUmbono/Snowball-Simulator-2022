using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RandomizeSiz();
    }

    void RandomizeSiz()
    {
        float px = Random.Range(1f, 3f);
        transform.localScale = new Vector3(px, px, px);
    }
    
void Update()
    {
        
    }
}
