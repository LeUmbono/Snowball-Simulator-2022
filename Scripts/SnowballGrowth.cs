using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballGrowth : MonoBehaviour
{ 
    public Rigidbody snowRB;
    public Transform snowball;
    public float growthRate;
    public float distance = 0;
    public int initial_mass = 5;
    private Vector3 sizeChange;
    private Vector3 currentPos;
    private Vector3 prevPos = new Vector3(0, 0, 0);
    // Update is called once per frame
    void FixedUpdate()
    {
        currentPos = snowball.position;
        currentPos.y = 0;
        distance = Vector3.Distance(snowball.position, prevPos);
        prevPos = currentPos;
        sizeChange = new Vector3(distance * growthRate, distance * growthRate, distance * growthRate);
        snowball.localScale = snowball.localScale + sizeChange;
        snowRB.mass = initial_mass + snowball.localScale.x;
        GameObject.Find("Snowball").GetComponent<SnowballTracks>()._brushSize = snowball.localScale.x;

    }
}
