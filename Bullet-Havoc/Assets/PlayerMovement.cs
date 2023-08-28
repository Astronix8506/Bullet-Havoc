using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //player Movement
    [SerializeField] private float _speed;
    private Rigidbody2D _rigidbody;
    private Vector2 _movementInput;

    //Player Dash
    [Header("Player Dash")]
    [SerializeField] private int dashSpeed;
    [SerializeField] private float dashCounter;
    [SerializeField] private float dashCooldown;
    

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _movementInput * _speed;
    }

    private void OnMove(InputValue inputValue)
    {
        _movementInput = inputValue.Get<Vector2>();
    }
}
