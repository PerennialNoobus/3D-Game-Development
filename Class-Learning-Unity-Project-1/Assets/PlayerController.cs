using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravity = 3.5f;
    public float speed = 2f;
    [Range(0.1f, 1f)]
    public float crouchSpeedMultiplier = 0.5f;
    public float jumpForce = 0.5f;

    private CharacterController controller;
    private Vector3 motion;
    private float currentSpeed = 0;
    private float velocity = 0;
    private bool crouching = false;
    private bool isGrounded = false;

    private void FixedUpdate()
    {
        isGrounded = controller.isGrounded;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGrounded == true)
        {
            if(crouching == false)
            {
                if(Input.GetKeyDown(KeyCode.Space) == true)
                {
                    velocity = jumpForce;
                }
                else if (Input.GetKeyDown(KeyCode.C) == true)
                {
                    crouching = true;
                    currentSpeed = speed * crouchSpeedMultiplier;
                    controller.height = 1;
                }
            }
        }
        if(crouching == true)
        {
            if(Input.GetKeyUp(KeyCode.C) == true)
            {
                crouching = false;
                currentSpeed = speed;
                controller.height = 2;
            }
        }
    }
    //ApplyMovement();
}
