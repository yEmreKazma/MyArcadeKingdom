using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private FixedJoystick joystick;
    [SerializeField]
    private float moveSpeed = 5f;

    private float horizontalMove = 0f;
    private float verticalMove = 0f;

    private void Update()
    {
        GetMovementInput();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        SetMovement();
    }

    private void SetMovement()
    {
        rb.velocity = GetNewVelocity();
    }

    private Vector3 GetNewVelocity()
    {
        return new Vector3(horizontalMove, rb.velocity.y, verticalMove)* moveSpeed * Time.fixedDeltaTime;
    }

    private void GetMovementInput()
    {
        horizontalMove = joystick.Horizontal;
        verticalMove = joystick.Vertical;
    }
}
