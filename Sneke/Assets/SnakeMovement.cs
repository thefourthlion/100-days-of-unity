using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    // snake movement speed and angle
    float moveSpeed = 1;
    float rotationAngle = 90f;

    // food position
    float foodX = 0;
    float foodY = 0;

    void Start()
    {
    }

    void Update()
    {

        // move forward at all times
        float moveAmount = moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
        if (Input.GetButtonDown("Horizontal"))
        {

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


            // Check if collision occurred with the food
            if (collision.gameObject.CompareTag("Food"))
            {
                // Destroy the collided object
                Destroy(gameObject);
            }
        }

    }
}
