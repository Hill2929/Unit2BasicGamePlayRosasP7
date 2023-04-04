using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionColloider : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game Over");
        }
    }
}