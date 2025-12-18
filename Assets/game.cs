using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    private Transform child;
    private List<Transform> children = new List<Transform>();
    public int enemys;
    void Start()
    {
        child = transform.Find("Targets");
        foreach (Transform t in child)
        {
            children.Add(t);
            enemys++;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (enemys <= 0)
        {
        #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
        }
        List<Transform> removeList = new List<Transform>();

        foreach (Transform t in children)
        {
            if(t.tag != "Enemy" || t == null)
            {
                enemys--;
                removeList.Add(t);
            }
        }

        foreach (Transform t in removeList)
        { 
            children.Remove(t);
            Debug.Log("Enemy Killed");
        }
    }
}
