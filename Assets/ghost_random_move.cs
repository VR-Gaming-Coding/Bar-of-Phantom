using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ghost_random_move : MonoBehaviour
{
/*    public List<GameObject> waypoints;*/
    [SerializeField]
    private GameObject[] waypoints; // An array of GameObjects
    public float speed = 0.5f;
    System.Random random = new System.Random();
    public String areatag = "doorArea";
    int index = 0;

    private float timer;
    private void Awake()
    {
        waypoints = GameObject.FindGameObjectsWithTag(areatag);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 destination = waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;
        // Calculate the direction from current position to the target position
        Vector3 moveDirection = (destination - transform.position).normalized;

        // Calculate the rotation angle towards the target direction
        float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;

        // Apply the rotation to make the character face the target direction
        transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

        float distance = Vector3.Distance(transform.position, destination);
        if (distance <= 0.05) index = random.Next(0, waypoints.Length);
    }
}

