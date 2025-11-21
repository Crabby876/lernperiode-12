using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    void Update()
    {
        if (player.transform.position.y > 0)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        }
        else 
        {
            transform.position = new Vector3(player.transform.position.x, 0, -10);
        }
    }
}
