using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiAir : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject antiAir;
    public GameObject bulletPrefab;
    private bool playerTracking = false;
    public float t = 1f;
    public float shootCooldown = 0.5f;
    private float shootTimer = 0f;
    private Vector2 playerVelocity;
    private Vector2 playerPosition;
    public Vector2 bulletDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shootTimer > 0f)
            shootTimer -= Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerTracking = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerTracking = false;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") 
        {
            Debug.Log("Player getrackt");
            PlayerMovement playerMovement = other.gameObject.GetComponent<PlayerMovement>();
            
            playerPosition = playerMovement.body.position;

            if (playerMovement != null)
            {
                playerVelocity = playerMovement.GetVelocity();
            }
            if (antiAir.tag != "Dead")
            {
                ShootPlayer();
            }
        }
    }

    private void ShootPlayer()
    {
        Vector2 newPosition;


        if (!playerTracking)
        {
            return;
        }
        if (shootTimer > 0f) 
        { 
            return;
        }

        shootTimer = shootCooldown;

        newPosition = PredictFlight();

        bulletDirection =  (newPosition - rb.position).normalized;

        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        bullet.GetComponent<bulletScript>().direction = bulletDirection;      

        
    }

    private Vector2 PredictFlight()
    {
        Vector2 newPosition = playerPosition;
        if (playerTracking)
        {
            newPosition = playerPosition + playerVelocity * t;
        }
        return newPosition;
    }
}
