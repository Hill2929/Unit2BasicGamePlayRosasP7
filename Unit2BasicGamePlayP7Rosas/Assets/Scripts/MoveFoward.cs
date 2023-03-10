using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    public float speed = 40.00f;
    public GameObject projectilePrefab; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a  projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
