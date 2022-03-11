using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpawner : MonoBehaviour
{
    public GameObject entityToSpread;
    public int numSpawn = 10;

    public float entityXSpread = 10;
    public float entityZSpread = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numSpawn; i++)
        {
            SpreadEntity();
        }

    }

    void SpreadEntity()
    {
        Vector3 randPosition = new Vector3(Random.Range(-entityXSpread, entityXSpread), 1, Random.Range(-entityZSpread, entityZSpread)) + transform.position;
        GameObject clone = Instantiate(entityToSpread, randPosition, Quaternion.Euler(90, 0, 0));
    }
}
