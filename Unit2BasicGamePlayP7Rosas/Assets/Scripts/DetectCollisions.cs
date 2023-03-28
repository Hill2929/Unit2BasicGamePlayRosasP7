using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameObject.FindWithTag("Player"))
        {
            PlayerStats.lives--;
            Debug.Log("lives=" + PlayerStats.lives);
            if (PlayerStats.lives < 1)
            {
                Debug.Log("Game Over!");
                Destroy(GameObject.FindWithTag("Player"));
                CancelInvoke();
            }

        }
        {
            Destroy(gameObject);
            Destroy(GameObject.FindWithTag("Food"));

            PlayerStats.score++;
            Debug.Log("Score=" + PlayerStats.score);
        }
    }
}


