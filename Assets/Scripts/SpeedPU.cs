using UnityEngine;

public class SpeedPU : MonoBehaviour
{
   // public GameObject pickupEffect;
    public float forceIncrement = 100f;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        player.GetComponent<SnowballMovement>().movementForce += forceIncrement;

        Destroy(gameObject);
    }
}
