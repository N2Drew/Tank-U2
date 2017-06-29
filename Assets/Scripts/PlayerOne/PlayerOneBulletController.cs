using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerOneBulletController : MonoBehaviour {

    Rigidbody2D bulletBody;
    Vector2 bulletStart;

    GameObject playerTwoHealthbar;
    PlayerTwoHealthController playerTwoHealthController;

    public float bulletSpeed = 1.5f;
    public int bulletStrength = 1;
    public float maxRange = 1;

	// Use this for initialization
	void Start () {
        bulletBody = this.GetComponent<Rigidbody2D>();
        playerTwoHealthbar = GameObject.Find("PlayerTwoHealthbar");
        playerTwoHealthController = playerTwoHealthbar.GetComponent<PlayerTwoHealthController>();


        transform.eulerAngles = GameObject.Find("PlayerOneSprite").transform.eulerAngles;
        bulletBody.velocity = transform.up*bulletSpeed;
        bulletStart = bulletBody.position;

        if (bulletStrength > 10)
        {
            bulletStrength = 10;
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Vector2.Distance(bulletStart, bulletBody.position) >= maxRange)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == GameObject.Find("PlayerTwoSprite"))
        {
            playerTwoHealthController.healthPoints-= bulletStrength;
            Destroy(gameObject);
        }
    }
}
