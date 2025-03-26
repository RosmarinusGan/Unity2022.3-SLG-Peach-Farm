using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float walkSpeed;

    private PlayerInput playerInput;
    private Vector2 inputAxis;
    private Rigidbody2D rb2D;
    private void Awake()
    {
        playerInput = new PlayerInput();
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        inputAxis = playerInput.Gameplay.Move.ReadValue<Vector2>();
        rb2D.MovePosition(rb2D.position + inputAxis * walkSpeed * Time.deltaTime);
    }
}
