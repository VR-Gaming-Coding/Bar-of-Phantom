using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost_floating : MonoBehaviour
{
    public float floatSpeed = 1.0f; // Speed of floating movement
    public float shakeAmount = 0.1f; // Amount of shaking

    private Vector3 originalPosition;
    private float timer;

    private void Start()
    {
        originalPosition = transform.position;
    }

    private void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // Calculate the new position with floating and shaking
        Vector3 newPosition = originalPosition + new Vector3(0f, Mathf.Sin(timer * floatSpeed) * shakeAmount, 0f);

        // Apply the new position
        transform.position = newPosition;
    }
}

