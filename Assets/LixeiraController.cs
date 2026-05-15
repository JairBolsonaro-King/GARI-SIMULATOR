using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LixeiraController : MonoBehaviour
{
    public float velocity = 5f;
    public float rotationSpeed = 5f;

    private Quaternion targetRotation;

    void Start()
    {
        targetRotation = transform.rotation;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        // Move object
        transform.position += new Vector3(
            horizontalInput * velocity * Time.deltaTime,
            0,
            0
        );

        // Set target rotation depending on direction
        if (horizontalInput > 0)
        {
            targetRotation = Quaternion.Euler(0, 0, 0); // Facing right
        }
        else if (horizontalInput < 0)
        {
            targetRotation = Quaternion.Euler(0, -180, 0); // Facing left
        }

        // Smoothly rotate
        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            targetRotation,
            rotationSpeed * Time.deltaTime
        );

        // Limit position
        if (transform.position.x > 10)
        {
            transform.position = new Vector3(
                10,
                transform.position.y,
                transform.position.z
            );
        }
        else if (transform.position.x < -10)
        {
            transform.position = new Vector3(
                -10,
                transform.position.y,
                transform.position.z
            );
        }
    }
}