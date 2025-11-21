using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed = 5f;                
    public float rotation = 5f;             
    public float gravityStrenght = 2f;      
    public float drag = 0.8f;                 

    public Vector2 velocity = Vector2.zero;
    private bool thrusting = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Vector2 moveDirection = body.transform.up;
            velocity += moveDirection * speed * Time.deltaTime;
            thrusting = true;
        }
        else
        {
            thrusting = false;
        }

        velocity += Vector2.down * gravityStrenght * Time.deltaTime;

        velocity = Vector2.Lerp(velocity, Vector2.zero, drag * Time.deltaTime);

        Vector2 newPosition = body.position + velocity * Time.deltaTime;
        body.MovePosition(newPosition);

        if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            float newRotation = body.rotation + rotation;
            body.MoveRotation(newRotation);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            float newRotation = body.rotation - rotation;
            body.MoveRotation(newRotation);
        }
    }

    public Vector2 GetVelocity()
    {
        return velocity;
    }
}
