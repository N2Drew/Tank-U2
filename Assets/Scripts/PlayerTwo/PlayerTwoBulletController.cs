using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerTwoBulletController : MonoBehaviour {

    Rigidbody2D bulletBody;
    Vector2 bulletStart;

    GameObject playerOneHealthbar;
    PlayerOneHealthController playerOneHealthController;

    public float bulletSpeed = 1.5f;
    public int bulletStrength = 1;
    public float maxRange = 1;

    // Use this for initialization
    void Start()
    {
        bulletBody = this.GetComponent<Rigidbody2D>();
        playerOneHealthbar = GameObject.Find("PlayerOneHealthbar");
        playerOneHealthController = playerOneHealthbar.GetComponent<PlayerOneHealthController>();

        transform.eulerAngles = GameObject.Find("PlayerTwoSprite").transform.eulerAngles;
        bulletBody.velocity = transform.up * bulletSpeed;
        bulletStart = bulletBody.position;

        if (bulletStrength > 10)
        {
            bulletStrength = 10;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //distance = Vector2.SqrMagnitude(bulletBody.position);
        if (Vector2.Distance(bulletStart, bulletBody.position) >= maxRange)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == GameObject.Find("PlayerOneSprite"))
        {
            playerOneHealthController.healthPoints-=bulletStrength;
            Destroy(gameObject);
        }
    }
}
