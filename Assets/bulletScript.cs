using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public Rigidbody2D body;
    public float bulletSpeed = 5f;
    [HideInInspector] public Vector2 direction;
    public GameObject bullet;
    private Vector3 parentPosition;

    void Start()
    {
        parentPosition = transform.parent.position;
        body.velocity = direction * bulletSpeed;
        
    }

    void Update()
    {
        DestroyBullet();
    }

    private void DestroyBullet()
    {
        if (body.position.y > parentPosition.y + 20 || body.position.x > parentPosition.x + 20 || body.position.y < parentPosition.y -20 || body.position.x < parentPosition.x -20)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PlayerMovement player = collision.GetComponent<PlayerMovement>();
            player.KillPlayer();
        }
    }
}
