using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerTwoTankController : MonoBehaviour {

    Rigidbody2D tankBody;
    //Animator tankAnimator;

    public float moveSpeed = 5;
    public GameObject playerTwoBullet;

    // Use this for initialization
    void Start () {
        tankBody = this.GetComponent<Rigidbody2D>();
        //tankAnimator = GameObject.Find("PlayerTwo").GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 moveVector = new Vector2(CrossPlatformInputManager.GetAxisRaw("PlayerTwoHorizontal"),
            CrossPlatformInputManager.GetAxisRaw("PlayerTwoVertical"));

        if (CrossPlatformInputManager.GetButtonDown("PlayerTwoFire")) {
            Instantiate(playerTwoBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f), transform.rotation);
        }

        tankBody.velocity = moveVector * moveSpeed;
        if (!tankBody.velocity.Equals(new Vector2(0, 0)))
        {
            //tankAnimator.SetBool("isMoving", true);
        }
        else
        {
            //tankAnimator.SetBool("isMoving", false);
        }
    }
}
