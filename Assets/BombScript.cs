using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public float drag = 1f;

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
            rb.velocity = new Vector2(player.GetVelocity().x * 0.7f, player.GetVelocity().y * 0.7f);
        }

        bombExplosion = FindObjectOfType<Explosion>();
        enemys = bombExplosion.enemys;

        
        rb.drag = drag;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.ToLower() == "level" || collision.gameObject.tag.ToLower() == "enemy")
        {
            GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(exp, 10f);
            Destroy(bomb);
            bombExplosion.DestroyAll(enemys);
        }
    }

}
