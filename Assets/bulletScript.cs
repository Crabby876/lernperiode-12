using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public Rigidbody2D body;
    public float bulletSpeed = 5f;
    [HideInInspector] public Vector2 direction;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        body.velocity = direction * bulletSpeed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        DestroyBullet();
    }

    private void DestroyBullet()
    {
        if (body.position.y > 20 || body.position.x > 20 || body.position.y < -20 || body.position.x < -20)
        {
            Destroy(bullet);
        }
    }
}
