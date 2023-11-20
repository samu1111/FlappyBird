using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;

    private Rigidbody2D _rigibody2D;
    private void Start()
    {
        _rigibody2D = GetComponent<Rigidbody2D>();
    }

   
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _rigibody2D.velocity = Vector2.up * _velocity;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rigibody2D.velocity.y * _rotationSpeed);
    }
}
