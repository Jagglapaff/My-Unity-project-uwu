using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float baseSpeed = 1.5f;
    public float acceleration = 1.0f;
    public float maxSpeed = 5.0f;
    public float horizontalInput;
    public float verticalInput;
    public GameObject projectilePrefab;

    // time
    public float timer = 0.0f;
    public float changeTimer = 1.0f;

    private float currentSpeed;

    void Start()
    {
        currentSpeed = baseSpeed;
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0).normalized;

        if (moveDirection != Vector3.zero)
        {
            if (horizontalInput > 0) // Pressing right
            {
                currentSpeed += acceleration * Time.deltaTime;
                currentSpeed = Mathf.Min(currentSpeed, maxSpeed);
            }
            else if (horizontalInput < 0) // Pressing left
            {
                currentSpeed -= acceleration * Time.deltaTime;
                currentSpeed = Mathf.Max(currentSpeed, baseSpeed);
            }
        }
        else
        {
            // No input, reset to base speed
            currentSpeed = baseSpeed;
        }

        // to keep player in bound
        timer += changeTimer * Time.deltaTime;

        if (transform.position.x < -10 + timer  )  // Pitää ottaa huomioon liikkuvuus kamera
        {
            transform.position = new Vector3(-10 + timer, transform.position.y, transform.position.z);
        }
        //////
        

        transform.Translate(moveDirection * currentSpeed * Time.deltaTime);

        // Shooting
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }


    }
}
