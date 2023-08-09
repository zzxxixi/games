using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using System;
using UnityEngine.InputSystem;
public class playermovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private Vector2 _inputDirection;
    [SerializeField] private float speed;

    public void Move(InputAction.CallbackContext context) 
    {
        _inputDirection = context.ReadValue<Vector2>();
       
    }
    private void FixedUpdate()
    {
        var position = (Vector2)transform.position;
        var targetPosition = position + _inputDirection;
        if (position == targetPosition) return;
        rb.DOMove(targetPosition,speed).SetSpeedBased();
    }
}
