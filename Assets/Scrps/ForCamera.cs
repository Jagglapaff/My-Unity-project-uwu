using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCamera : MonoBehaviour
{

    public float moveSpeed = 1.5f;  // Going forward

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the player
        Vector3 currentPosition = transform.position;

        // Calculate the new position to move to the right
        Vector3 newPosition = currentPosition + new Vector3(moveSpeed * Time.deltaTime, 0, 0);

        // Update the player's position
        transform.position = newPosition;
    }
}
