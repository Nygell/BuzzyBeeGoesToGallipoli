using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField, Range(0f, 50f)]
    private float _maxSpeed = 5f;
    [SerializeField, Range(0f, 25f)]
    private float _maxAcceleration = 1f;

    private Vector2 _direction, _desiredVelocity;
    private InputManager _inputManager;
    private Rigidbody2D _rigidBody2D;
    void Awake()
    {
        _inputManager = GetComponent<InputManager>();
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _direction.x = _inputManager.Controller.RetrieveHorizontalInput();
        _direction.y = _inputManager.Controller.RetrieveVerticalInput();
        _desiredVelocity = new Vector2(_direction.x, _direction.y) * Mathf.Max(_maxSpeed, 0f);

        if (!_inputManager.Bounds.InBounds(_rigidBody2D))
        {
            _desiredVelocity.x = 0f;
        }
    }

    private void FixedUpdate()
    {
        var velocity = _rigidBody2D.velocity;

        velocity.x = Mathf.MoveTowards(velocity.x, _desiredVelocity.x, _maxAcceleration);
        velocity.y = Mathf.MoveTowards(velocity.y, _desiredVelocity.y, _maxAcceleration);

        _rigidBody2D.velocity = velocity;

    }
}
