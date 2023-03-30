using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    // Minimun time between dog spawns
    public float dogSpawnInterval = 1.0f;
    // Time elapsed since the last dog generation
    private float timeSinceLastDog = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // Update the time since the last dog was spawned
        timeSinceLastDog += Time.deltaTime;
        // If the Space key is pressed and enough time has passed since the last dog was spawned, spawn a new dog
        if (Input.GetKeyDown(KeyCode.Space) && timeSinceLastDog >= dogSpawnInterval)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeSinceLastDog = 0.0f;// Reset the time since the last dog was spawned
        }
    }
}
