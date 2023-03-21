using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
        // Debug.Log("Player ship bumped into enemy");
        Debug.Log(this.name + "--Collided with--" + other.gameObject.name);
    }

    void OnTriggerEnter(Collider other) 
    {
        // Debug.Log("Player ship bumped into trigger");
        Debug.Log($"{this.name} **Triggered by** {other.gameObject.name}");
    }
}
