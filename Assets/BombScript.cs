using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public float drag = 0.5f;
    public float forwardBoost = 5f;

    public Rigidbody2D rb;
    public GameObject bomb;
    public GameObject explosion;

    private Explosion bombExplosion;
    private List<GameObject> enemys;

    void Start()
    {
        PlayerMovement player = FindObjectOfType<PlayerMovement>();
        if (player != null)
        {
            rb.velocity = player.GetVelocity();

            Vector2 forwardDirection = player.transform.up;
            rb.velocity += forwardDirection * forwardBoost;
        }

        rb.drag = drag;

        bombExplosion = FindObjectOfType<Explosion>();
        if (bombExplosion != null)
        {
            enemys = bombExplosion.enemys;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag.ToLower();

        if (tag == "level" || tag == "enemy")
        {
            GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(exp, 10f);

            if (bombExplosion != null && enemys != null)
            {
                bombExplosion.DestroyAll(enemys);
            }

            Destroy(bomb);
        }
    }

}
