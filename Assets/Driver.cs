using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I am just testing that itll save 
public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 300f;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 20f;
 
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0,moveAmount,0);
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }
    
}
