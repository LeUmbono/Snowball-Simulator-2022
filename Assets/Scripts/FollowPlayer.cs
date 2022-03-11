using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    [Range(0, 5)]
    private int counter = 1;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && counter < 5)
        {
            counter++;
            offset.y += 1f;
            offset.z -= 10f;
        }

        if (Input.GetKeyDown("r") && counter > 1)
        {
            counter--;
            offset.y -= 1f;
            offset.z += 10f;
        }
        
        transform.position = player.position + offset;
    }
}
