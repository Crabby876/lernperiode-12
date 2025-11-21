using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosion;
    public List<GameObject> enemys;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.ToLower() == "enemy")
        {
            enemys.Clear();
            enemys.Add(collision.gameObject);

        }
    }

    public void DestroyAll(List<GameObject> enemys)
    {
        foreach (GameObject enemy in enemys)
        {
            enemy.tag = "Dead";
            SpriteRenderer sr = enemy.GetComponent<SpriteRenderer>();
            sr.color = Color.black;
            GameObject exp = Instantiate(explosion, enemy.transform.position, Quaternion.identity);
            Destroy(exp, 10f);
            Destroy(enemy,20f);
        }
    }
}
