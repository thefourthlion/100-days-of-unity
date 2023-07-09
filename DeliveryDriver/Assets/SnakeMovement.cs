using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    // float steerSpeed = -250;
    float moveSpeed = 5f;
    float rotationAngle = 90f;
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            // move forward at all times
            float moveAmount = moveSpeed * Time.deltaTime;
            transform.Translate(0, moveAmount, 0);

            // left and right movements
            float rotationInput = Input.GetAxis("Horizontal");
            if (rotationInput > 0f)
            {
                // Rotate right by fixed angle
                transform.Rotate(0f, 0f, -rotationAngle);
                Debug.Log("Moving right");
            }
            else if (rotationInput < 0f)
            {
                // Rotate left by fixed angle

                transform.Rotate(0f, 0f, rotationAngle);
                Debug.Log("Moving left");

            }
        }

    }
}
