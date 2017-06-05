using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerOneTankController : MonoBehaviour {

    Rigidbody2D tankBody;
    public float moveSpeed = 5;
    private float turningRadius = 0;

	// Use this for initialization
	void Start () {
        tankBody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 moveVector = new Vector2(CrossPlatformInputManager.GetAxisRaw("PlayerOneHorizontal"), 
            CrossPlatformInputManager.GetAxisRaw("PlayerOneVertical"));
        bool isFiring = CrossPlatformInputManager.GetButton("PlayerOneFire");

        //tankBody.AddForce(moveVector);
        tankBody.velocity = moveVector;
	}
}
