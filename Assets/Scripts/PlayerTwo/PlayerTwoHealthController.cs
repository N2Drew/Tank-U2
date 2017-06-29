using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoHealthController : MonoBehaviour
{

    Animator healthbarAnimator;
    public int healthPoints = 10;

    // Use this for initialization
    void Start()
    {
        healthbarAnimator = GameObject.Find("PlayerTwoHealthbar").GetComponent<Animator>();
        if (healthPoints > 10)
        {
            healthPoints = 10;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (healthPoints)
        {
            case 10:
                healthbarAnimator.SetInteger("healthPoints", 10);
                break;

            case 9:
                healthbarAnimator.SetInteger("healthPoints", 9);
                break;

            case 8:
                healthbarAnimator.SetInteger("healthPoints", 8);
                break;

            case 7:
                healthbarAnimator.SetInteger("healthPoints", 7);
                break;

            case 6:
                healthbarAnimator.SetInteger("healthPoints", 6);
                break;

            case 5:
                healthbarAnimator.SetInteger("healthPoints", 5);
                break;

            case 4:
                healthbarAnimator.SetInteger("healthPoints", 4);
                break;

            case 3:
                healthbarAnimator.SetInteger("healthPoints", 3);
                break;

            case 2:
                healthbarAnimator.SetInteger("healthPoints", 2);
                break;

            case 1:
                healthbarAnimator.SetInteger("healthPoints", 1);
                break;

            case 0:
                healthbarAnimator.SetInteger("healthPoints", 0);
                break;
        }
    }
}
