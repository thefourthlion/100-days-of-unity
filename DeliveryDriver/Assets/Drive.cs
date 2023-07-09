using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    float steerSpeed = -250;
    float moveSpeed = 5f;
    float boostSpeed = 10f;
    float slowSpeed = 5f;
    void Start()
    {
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);



    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Boost")
        {
            Debug.Log("Hit Boost");
            moveSpeed = boostSpeed;
        }

        if (other.tag != "Boost" && other.tag != "Package")
        {
            Debug.Log("Hit Slow");
            moveSpeed = slowSpeed;
        }
    }
}
