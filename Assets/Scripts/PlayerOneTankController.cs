using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerOneTankController : MonoBehaviour {

    Rigidbody2D tankBody;
    Animator tankAnimator;

    public float moveSpeed = 5;

	// Use this for initialization
	void Start () {
        tankBody = this.GetComponent<Rigidbody2D>();
        tankAnimator = GameObject.Find("PlayerOneSprite").GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 moveVector = new Vector2(CrossPlatformInputManager.GetAxisRaw("PlayerOneHorizontal"), 
            CrossPlatformInputManager.GetAxisRaw("PlayerOneVertical"));
        bool isFiring = CrossPlatformInputManager.GetButton("PlayerOneFire");

        tankBody.velocity = moveVector*moveSpeed;
        Debug.Log(tankBody.velocity);
        if(!tankBody.velocity.Equals(new Vector2(0,0)))
        {
            tankAnimator.SetFloat("Speed", 1);
        } else
        {
            tankAnimator.SetFloat("Speed", 0);
        }

	}
}
