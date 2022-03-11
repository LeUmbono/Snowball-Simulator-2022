using UnityEngine;

public class GrowthPU : MonoBehaviour
{
   // public GameObject pickupEffect;
    public float growthRateIncrement = 0.0001f;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        player.GetComponent<SnowballGrowth>().growthRate += growthRateIncrement;

        Destroy(gameObject);
    }
}
