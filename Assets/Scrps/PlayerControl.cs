using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 1.5f;  // Going forward

    public float verticalSpeed = 4.0f;

    public float verticalInput;

    public float horizontalspeed = 4.0f;

    public float horizontalInput;

    public GameObject projectilePrefab;
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


        // Lets add away to move up and down

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * verticalSpeed);

        // To move vertically
        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 tempPosition = currentPosition + new Vector3((horizontalInput * 0) * Time.deltaTime, 0, 0);

            // Update the player's position
            transform.position = tempPosition;

        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {

            Vector3 tempPosition = currentPosition + new Vector3((horizontalInput + moveSpeed) * Time.deltaTime, 0, 0);

            // Update the player's position
            transform.position = tempPosition;
        }

        /// Shooting 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }

}
