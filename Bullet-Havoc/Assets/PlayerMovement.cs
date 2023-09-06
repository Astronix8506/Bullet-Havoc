using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //player Movement
    [Header("Player's Overal Speed")]
    [SerializeField] private float playerMoveSpeed = 6;
    [SerializeField] private float activePlayerMoveSpeed;
    private Rigidbody2D _rigidbody;
    private Vector2 _movementInput;

    //Player Dash
    [Header("Player Dash")]
    [SerializeField] private int dashSpeed = 10;
    public float dashRate = 2f;
    float nextDashTime = 0f;
    bool isDashing = false;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

    }
    private void Start()
    {
        activePlayerMoveSpeed = playerMoveSpeed;
    }
    private void FixedUpdate()
    {
        _rigidbody.velocity = _movementInput * activePlayerMoveSpeed;

        if (Time.time >= nextDashTime) 
        {
            nextDashTime = Time.time + 1f / dashRate;

            activePlayerMoveSpeed = playerMoveSpeed;

            isDashing = false;
        } 
    }

    private void OnMove(InputValue inputValue)
    {
        _movementInput = inputValue.Get<Vector2>();
    }

    private void OnDash(InputValue inputValue)
    {
        if (!isDashing)
        {
            Debug.Log("Player is dashing");
            activePlayerMoveSpeed = dashSpeed;

            isDashing = true;

        }


    }

}
