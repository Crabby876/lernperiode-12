using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBomb : MonoBehaviour
{
    public GameObject bombPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBomb();
        }
    }

    void SpawnBomb()
    {
        GameObject newBomb = Instantiate(bombPrefab, transform.position, transform.rotation);
    }
}
