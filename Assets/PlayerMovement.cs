using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D body;
    public GameObject player;

    public float speed = 5f;
    public float rotation = 5f;
    public float maxSpeed = 10f;

    public float gravityStrenght = 2f;
    public float drag = 0.8f;

    private Vector2 velocity = Vector2.zero;
    private bool isAlive = true;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = player.GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (isAlive)
        {
            HandleInput();
        }

        ApplyPhysics();
    }

    private void HandleInput()
    {
        // Thrust
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Vector2 moveDirection = body.transform.up;
            velocity += moveDirection * speed * Time.fixedDeltaTime;
        }

        // Rotation
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            body.MoveRotation(body.rotation + rotation);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            body.MoveRotation(body.rotation - rotation);
        }
    }

    private void ApplyPhysics()
    {
        // Gravity
        velocity += Vector2.down * gravityStrenght * Time.fixedDeltaTime;

        // Drag
        velocity = Vector2.Lerp(velocity, Vector2.zero, drag * Time.fixedDeltaTime);

        // Geschwindigkeitsbegrenzung
        if (velocity.magnitude > maxSpeed)
        {
            velocity = velocity.normalized * maxSpeed;
        }

        // Position aktualisieren
        Vector2 newPosition = body.position + velocity * Time.fixedDeltaTime;
        body.MovePosition(newPosition);

        CorrectScale();
    }

    public void KillPlayer()
    {
        isAlive = false;
        player.tag = "Dead";

        if (spriteRenderer != null)
        {
            spriteRenderer.color = Color.black;
        }

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public Vector2 GetVelocity()
    {
        return velocity;
    }

    private void CorrectScale()
    {
        if (spriteRenderer == null) return;

        float zAngle = body.rotation;
        spriteRenderer.flipX = (zAngle > 60f && zAngle < 120f);
    }
}
